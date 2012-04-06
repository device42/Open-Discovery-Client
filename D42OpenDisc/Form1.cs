using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting; 
using Renci.SshNet;
using System.Diagnostics;
using System.Threading.Tasks;

namespace D42OpenDisc
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            TraceListener debugListener = new MyTraceListener(logbox);
            Debug.Listeners.Add(debugListener);
            Control.CheckForIllegalCrossThreadCalls = false;
           
        }

        private void winrunnow_Click(object sender, EventArgs e)
        {
            logbox.Text += "\nStarting Windows Discovery. Please wait as this might take a while........\n";
            tabControl1.SelectedTab = tabControl1.TabPages[2];
            winrunnow.Enabled = false;
            var result = "";
                System.Threading.Tasks.Task task_win = new System.Threading.Tasks.Task(() =>
                        {
            
            
            try {
                
                var cpy = Python.CreateRuntime();
                dynamic cpl = cpy.UseFile("l101.py");
                result += cpl.win(winuser.Text, winpass.Text, alladcomputers.Checked, alladservers.Checked, winrange.Checked, allinlist.Checked, winfrom.Text, winto.Text, wincomputers.Text);
            }

            catch (Exception ex)
            {
                result += ex.ToString();
            }
            Trace.Write(result);
                        });
                task_win.Start();
               task_win.ContinueWith(t => winrunnow.Enabled = true);
        }

        private void linuxrange_CheckedChanged(object sender, EventArgs e)
        {
            if (linuxrange.Checked)
            {
                linuxfrom.Visible = true;
                linuxto.Visible = true;
                linuxfromlabel.Visible = true;
                linuxtolabel.Visible = true;
                linuxlist.Visible = false;
            }
            else
            {
                linuxfrom.Visible = false;
                linuxto.Visible = false;
                linuxlist.Visible = true;
                linuxfromlabel.Visible = false;
                linuxtolabel.Visible = false;
            }
        }

        private void allinlist_CheckedChanged(object sender, EventArgs e)
        {
            if (allinlist.Checked)
            {
                wincomputers.Visible = true;
                winfrom.Visible = false;
                winto.Visible = false;
                wintolabel.Visible = false;
                winfromlabel.Visible = false;
            }

        }

        private void gothroughlinux(string c, string username, string password)
        {

            var result = "";
            

                           
            using (var client = new SshClient(c, username, password))
            {
                result += "\n=============================\n ";
                result += "Discovering Device: ";
                result += c;
                result += "\n=============================\n ";
                try
                {
                    client.ConnectionInfo.Timeout = TimeSpan.FromSeconds(20);
                    client.Connect();
                    

                    var device_name = client.CreateCommand("/bin/hostname");
                    device_name.CommandTimeout = TimeSpan.FromSeconds(5);
                    device_name.Execute();


                    var release = client.CreateCommand("/usr/bin/python -m platform");
                    release.CommandTimeout = TimeSpan.FromSeconds(5);
                    release.Execute();

                    var manufacturer = client.CreateCommand("sudo /usr/sbin/dmidecode -s system-manufacturer");
                    manufacturer.CommandTimeout = TimeSpan.FromSeconds(5);
                    manufacturer.Execute();

                    var hardware = client.CreateCommand("sudo /usr/sbin/dmidecode -s system-product-name");
                    hardware.CommandTimeout = TimeSpan.FromSeconds(5);
                    hardware.Execute();

                    var serial_no = client.CreateCommand("sudo /usr/sbin/dmidecode -s system-serial-number");
                    serial_no.CommandTimeout = TimeSpan.FromSeconds(5);
                    serial_no.Execute();


                    var ifconfig = client.CreateCommand("/sbin/ifconfig -a | grep -A 2 Ethernet");
                    ifconfig.CommandTimeout = TimeSpan.FromSeconds(5);
                    ifconfig.Execute();
                    result += device_name.Result;
                    client.Disconnect();
                    
                    var cpy = Python.CreateRuntime();
                    dynamic cpl = cpy.UseFile("l101.py");
                    result += cpl.linux(device_name.Result, release.Result, manufacturer.Result, hardware.Result, serial_no.Result, ifconfig.Result);

                           
                }
                catch (Exception ex)
                {
                    client.Disconnect(); 
                    result += ex.ToString();
                }

            }
            Trace.WriteLine(result);

        }

        private void linuxrun_Click(object sender, EventArgs e)
        {
            if (linuxuser.Text == "" || linuxpass.Text == "") { MessageBox.Show("Enter Username and password"); }
            else
            {
                tabControl1.SelectedTab = tabControl1.TabPages[2];
                linuxrun.Enabled = false;
                
                System.Threading.Tasks.Task task = new System.Threading.Tasks.Task(() =>
                        {
                            
                            if (linuxlistradio.Checked)
                            {


                                foreach (string c in linuxlist.Lines)
                                {
                                    try
                                    {
                                        if ((c.Trim().CompareTo("")) != 0)
                                        {
                                            gothroughlinux(c.Trim(), linuxuser.Text, linuxpass.Text);
                                        }
                                       
                                    }
                                    catch (Exception ex)
                                    {
                                        Trace.WriteLine(ex.ToString());
                                    }
                                    
                                }
                                
                            }
                            else
                            {
                                try
                                {
                                    var ipy = Python.CreateRuntime();
                                    dynamic ipl = ipy.UseFile("l101.py");
                                    List<string> iplist = ipl.ipRange(linuxfrom.Text, linuxto.Text);

                                    foreach (string ip in iplist)
                                    {
                                        try
                                        {
                                            gothroughlinux(ip, linuxuser.Text, linuxpass.Text);
                                        }
                                        catch (Exception ex)
                                        {
                                            Trace.WriteLine(ex.ToString());
                                        }
                                        
                                    }

                                }
                                catch (Exception ex)
                                {
                                    Trace.WriteLine("Please check IP range again");
                                }
                            }
                            
                        });
                task.Start();
                task.ContinueWith(t => linuxrun.Enabled = true);
            }
        }

        private void alladservers_CheckedChanged(object sender, EventArgs e)
        {
            if (alladservers.Checked)
            {
                winfrom.Visible = false;
                winto.Visible = false;
                wintolabel.Visible = false;
                winfromlabel.Visible = false;
                wincomputers.Visible = false;
            }
        }

        private void alladcomputers_CheckedChanged(object sender, EventArgs e)
        {
            if (alladcomputers.Checked)
            {
                winfrom.Visible = false;
                winto.Visible = false;
                wintolabel.Visible = false;
                winfromlabel.Visible = false;
                wincomputers.Visible = false;
            }
        }

        private void winrange_CheckedChanged(object sender, EventArgs e)
        {
            if (winrange.Checked)
            {
                winfrom.Visible = true;
                winto.Visible = true;
                wintolabel.Visible = true;
                winfromlabel.Visible = true;
                wincomputers.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://docs.device42.com/open-discovery-client");
        }

    }
    public class MyTraceListener : TraceListener
    {
        private TextBoxBase output;

        public MyTraceListener(TextBoxBase output)
        {
            this.Name = "Trace";
            this.output = output;
        }

        public override void Write(string message)
        {

            Action append = delegate()
            {
                output.AppendText(string.Format("[{0}] ", DateTime.Now.ToString()));
                //output.AppendText(message);
                output.Text += message;
            };
            if (output.InvokeRequired)
            {
                output.BeginInvoke(append);
            }
            else
            {
                append();
            }

        }

        public override void WriteLine(string message)
        {
            Write(message + Environment.NewLine);
        }

    }

}
