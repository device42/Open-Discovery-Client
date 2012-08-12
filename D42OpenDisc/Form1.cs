using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Renci.SshNet;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Management;
using System.Text.RegularExpressions;
using System.IO;
using OfficeOpenXml;

namespace D42OpenDisc
{

    public partial class Form1 : Form
    {
        int linux_total_count, win_total_count;
        int linux_temp = 0;
        int win_temp = 0;
        bool being_written = false;
        List<string[]> all_the_values = new List<string[]>();
        List<string[]> all_the_ip_values = new List<string[]>();
        List<string[]> all_the_ip6_values = new List<string[]>();
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationTokenSource tokenSource_win = new CancellationTokenSource();
        string folder_path = "Default";
        
        public Form1()
        {
            InitializeComponent();
            TraceListener debugListener = new MyTraceListener(logbox);
            Debug.Listeners.Add(debugListener);
            Control.CheckForIllegalCrossThreadCalls = false;
            file_path.Text = "Current folder where file is saved: " + folder_path;

        }

        private void gothroughwin(string c, string username, string password)
        {

            


            //    tokenSource = new CancellationTokenSource();
            System.Threading.Tasks.Task task_1 = new System.Threading.Tasks.Task(() =>
            {

                try
                {
                    ConnectionOptions oConn = new ConnectionOptions();
                    if (winuser.Text != "") 
                    {
                        oConn.Username = winuser.Text;
                        oConn.Password = winpass.Text;                 
                    }
                    
                    string cname = "\\\\"+c+"\\root\\CIMV2";
                    bool not_has = true;
                    System.Management.ManagementScope oMs = new System.Management.ManagementScope(@cname, oConn);
                    System.Management.ObjectQuery oQuery_cs = new System.Management.ObjectQuery("select Name, Manufacturer, Model, TotalPhysicalMemory from Win32_ComputerSystem");
                    System.Management.ObjectQuery oQuery_bios = new System.Management.ObjectQuery("select SerialNumber from Win32_BIOS");
                    System.Management.ObjectQuery oQuery_os = new System.Management.ObjectQuery("select * from Win32_OperatingSystem");
                    
                    System.Management.ObjectQuery oQuery_nw = new System.Management.ObjectQuery("select * from Win32_NetworkAdapterConfiguration where IPEnabled = True");
                    ManagementObjectSearcher oSearcher_cs = new ManagementObjectSearcher(oMs, oQuery_cs);
                    ManagementObjectSearcher oSearcher_bios = new ManagementObjectSearcher(oMs, oQuery_bios);
                    ManagementObjectSearcher oSearcher_os = new ManagementObjectSearcher(oMs, oQuery_os);
                    
                    ManagementObjectSearcher oSearcher_nw = new ManagementObjectSearcher(oMs, oQuery_nw);
                    ManagementObjectCollection oReturnCollection_cs = oSearcher_cs.Get();
                    ManagementObjectCollection oReturnCollection_bios = oSearcher_bios.Get();
                    ManagementObjectCollection oReturnCollection_os = oSearcher_os.Get();
                    

                    ManagementObjectCollection oReturnCollection_nw = oSearcher_nw.Get();
                    string UPLOADdata = "";
                    string device_name = "";
                    string list_mftr = ""; string list_hw = ""; string list_sn = "", list_mem = "";
                    string list_os = ""; string list_osver = ""; string list_osmftr = ""; string list_osserial = ""; string list_osverno = "";
                    string list_cpucount = ""; string list_cpucore = ""; string list_cpuspeed = "";
                    foreach (ManagementObject oReturn in oReturnCollection_cs)
                    {

                        device_name = oReturn["Name"].ToString().ToLower();
                        

                        foreach (string[] subList in all_the_values)
                        {
                            if (subList[0] == device_name) { not_has = false; break; }
                        }


                        if (not_has) {
                        
                            //Trace.WriteLine(add_to_all_the_values);
                            string Mftr = oReturn["Manufacturer"].ToString().TrimStart().TrimEnd();
                            string manufacturer = "";
                           string[] strArray = new string[] { "VMware, Inc.", "Bochs", "KVM", "QEMU", "Microsoft Corporation", "Xen"};
                            foreach (string m_s in strArray) {
                                if (m_s == Mftr) { manufacturer = "virtual"; UPLOADdata += "&manufacturer=vmware"; list_mftr = "virtual";  break; }
                        
                            }
                            if (manufacturer != "virtual") {
                                UPLOADdata += "&manufacturer=" + Mftr + "&hardware=" + oReturn["Model"].ToString().TrimStart().TrimEnd();
                                list_hw = oReturn["Model"].ToString().TrimStart().TrimEnd();
                                foreach (ManagementObject oReturnsn in oReturnCollection_bios)
                                {
                                    UPLOADdata += "&serial_no=" + oReturnsn["SerialNumber"].ToString();
                                    list_sn = oReturnsn["SerialNumber"].ToString();
                                }
                            }
                            long mem3 = upper_power_of_two(Convert.ToInt64(oReturn["TotalPhysicalMemory"].ToString()) / 1047552);
                            UPLOADdata += "&memory=" + mem3.ToString();
                            list_mem = mem3.ToString();
                        }
                    }

                    if (not_has)
                    {
                        foreach (ManagementObject oReturn in oReturnCollection_os)
                        {
                            list_os = oReturn["Caption"].ToString();
                            list_osver = oReturn["CSDVersion"].ToString();
                            list_osmftr = oReturn["Manufacturer"].ToString();
                            list_osserial = oReturn["SerialNumber"].ToString();
                            list_osverno = oReturn["Version"].ToString();
                        }
                        try
                        {
                            System.Management.ObjectQuery oQuery_cpu = new System.Management.ObjectQuery("select maxclockspeed,numberOfCores from win32_processor");
                            ManagementObjectSearcher oSearcher_cpu = new ManagementObjectSearcher(oMs, oQuery_cpu);
                            ManagementObjectCollection oReturnCollection_cpu = oSearcher_cpu.Get();
                            int cpucount = 0; decimal cspeed = 0.0m;
                            string cpuspeed = ""; string cpucores = "";
                            foreach (ManagementObject oReturn in oReturnCollection_cpu)
                            {
                                cpucount += 1;
                                cpuspeed = oReturn["maxclockspeed"].ToString();
                                cspeed = Convert.ToDecimal(cpuspeed) / 1000;
                                cpucores = oReturn["numberOfCores"].ToString();
                            }
                            if (cpucount > 0)
                            {
                                list_cpucount = cpucount.ToString(); list_cpucore = cpucores; list_cpuspeed = Convert.ToString(cspeed);
                            }
                        }
                        catch
                        {
                            Trace.WriteLine("Could not get CPU info for " + c);
                        }

                        all_the_values.Add(new string[] { device_name, list_mftr, list_hw, list_sn, list_os, list_osver, list_osverno, list_osserial, list_osmftr, list_mem, list_cpucount, list_cpucore, list_cpuspeed });
                        
                        foreach (ManagementObject oReturn in oReturnCollection_nw)
                        {
                            string macadd = oReturn["MACAddress"].ToString();
                            string tag = oReturn["Description"].ToString();
                            string[] addresses = (string[])oReturn["IPAddress"];
                            foreach (string ipaddress in addresses)
                            {
                                if (ipaddress.Contains('.')) {
                                all_the_ip_values.Add(new string[] { ipaddress,tag, macadd, device_name});
                                }
                                else {
                                    all_the_ip6_values.Add(new string[] { ipaddress,tag, macadd, device_name});
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Trace.WriteLine("Error for: "+c+" "+ex.ToString());
                }




            }, tokenSource_win.Token);
            //only start the task if concurrency thread is there, otherwise wait and start later.
            task_1.Start();
            task_1.ContinueWith(t => check_win_progress());
        }


        private void winrunnow_Click(object sender, EventArgs e)
        {

                winrunnow.Enabled = false;
                win_temp = 0;
                win_progressbar.Value = 0;
                win_progress_label.ForeColor = Color.Blue;
                tokenSource_win = new CancellationTokenSource();
                System.Threading.Tasks.Task task_win = new System.Threading.Tasks.Task(() =>
                        {
                            if (winrange.Checked)
                            {
                                win_progress_label.Text = "Progress: Getting the IP List...";
                                try
                                {

                                    List<string> ips = get_ip_list(winfrom.Text, winto.Text);
                                    win_cancel.Enabled = true;
                                    win_total_count = ips.Capacity;
                                    win_progress_label.Text = "Progress: Starting...";

                                    foreach (string ip in ips)
                                    {
                                        try
                                        {
                                            gothroughwin(ip, winuser.Text, winpass.Text);
                                        }
                                        catch (Exception ex)
                                        {
                                            Trace.WriteLine("Error for IP: " + ip + " " + ex.ToString());
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    Trace.WriteLine(ex.ToString());
                                    Trace.WriteLine("Please check IP range input values again");
                                    win_progress_label.ForeColor = Color.Red;
                                    win_progress_label.Text = "Progress: Error getting the IP List, Please check input...";
                                    winrunnow.Enabled = true;
                                }
                            }


                            else if (allinlist.Checked)
                            {

                                win_total_count = winlist.GetLineFromCharIndex(winlist.TextLength) + 1;

                                win_progress_label.Text = "Progress: Starting...";
                                win_cancel.Enabled = true;
                                if (win_total_count == 1 && winlist.Text == "")
                                {
                                    win_empty_list();
                                }
                                foreach (string c in winlist.Lines)
                                {
                                    try
                                    {
                                        if ((c.Trim().CompareTo("")) != 0)
                                        {
                                            gothroughwin(c.Trim(), winuser.Text, winpass.Text);
                                        }
                                        else { check_win_progress(); }
                                    }
                                    catch (Exception ex)
                                    {
                                        Trace.WriteLine(ex.ToString());
                                    }

                                }
                            }
                        });
                task_win.Start();
                task_win.ContinueWith(t => Console.WriteLine("started"));
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
                winlist.Visible = true;
                winfrom.Visible = false;
                winto.Visible = false;
                wintolabel.Visible = false;
                winfromlabel.Visible = false;
            }

        }
        private void gothroughlinux(string c, string username, string password)
        {

            System.Threading.Tasks.Task task_1 = new System.Threading.Tasks.Task(() =>
                        {
                            try
                            {
                                using (var client = new SshClient(c, username, password))
                                {
                                    try
                                    {
                                        string list_mftr = ""; string list_hw = ""; string list_sn = ""; long list_mem = 0;
                                        string list_os = ""; string list_osver = ""; string list_osmftr = ""; string list_osserial = ""; string list_osverno = "";
                                        string list_cpucount = ""; string list_cpucore = ""; string list_cpuspeed = "";
                                        bool not_has = true;
                                        client.ConnectionInfo.Timeout = TimeSpan.FromSeconds(5);
                                        client.Connect();

                                        var device_name = client.CreateCommand("/bin/hostname");
                                        device_name.CommandTimeout = TimeSpan.FromSeconds(2);
                                        device_name.Execute();

                                        string dev_name = device_name.Result.Trim();
                                        if (ignoreDomain.Checked) { dev_name = dev_name.Split('.')[0]; }
                                        foreach (string[] subList in all_the_values)
                                        {
                                            if (subList[0] == dev_name) { not_has = false; break; }
                                        }

                                        if (not_has)
                                        {
                                            var release = client.CreateCommand("/usr/bin/python -m platform");
                                            release.CommandTimeout = TimeSpan.FromSeconds(2);
                                            release.Execute();
                                            string prfx = "";
                                            if (username != "root") { prfx = "sudo "; }
                                            var manufacturer = client.CreateCommand(prfx + "/usr/sbin/dmidecode -s system-manufacturer");
                                            manufacturer.CommandTimeout = TimeSpan.FromSeconds(2);
                                            manufacturer.Execute();

                                            var hardware = client.CreateCommand(prfx + "/usr/sbin/dmidecode -s system-product-name");
                                            hardware.CommandTimeout = TimeSpan.FromSeconds(2);
                                            hardware.Execute();

                                            var serial_no = client.CreateCommand(prfx + "/usr/sbin/dmidecode -s system-serial-number");
                                            serial_no.CommandTimeout = TimeSpan.FromSeconds(2);
                                            serial_no.Execute();

                                            var ifconfig = client.CreateCommand("/sbin/ifconfig -a | grep -A 2 Ethernet");
                                            ifconfig.CommandTimeout = TimeSpan.FromSeconds(2);
                                            ifconfig.Execute();

                                            var meminfo = client.CreateCommand("grep MemTotal /proc/meminfo");
                                            meminfo.CommandTimeout = TimeSpan.FromSeconds(2);
                                            meminfo.Execute();

                                            var cpuinfo = client.CreateCommand(prfx + "/usr/sbin/dmidecode -s processor-frequency | grep MHz");
                                            cpuinfo.CommandTimeout = TimeSpan.FromSeconds(2);
                                            cpuinfo.Execute();

                                            var coreinfo = client.CreateCommand(prfx + "/usr/sbin/dmidecode -t processor | grep \"Core Count\" | head -1");
                                            coreinfo.CommandTimeout = TimeSpan.FromSeconds(2);
                                            coreinfo.Execute();

                                            client.Disconnect();

                                            string os = Regex.Split(release.Result, "-with-")[1].Split('-')[0];
                                            string osver = Regex.Split(release.Result, "-with-")[1].Split('-')[1];
                                            //string osverno = Regex.Split(release.Result, "-with-")[0];
                                            list_os = os; list_osver = osver; //list_osverno = osverno;
                                            string Mftr = manufacturer.Result.Trim().Replace("# SMBIOS implementations newer than version 2.6 are not\n# fully supported by this version of dmidecode.\n","");

                                            string[] strArray = new string[] { "VMware, Inc.", "Bochs", "KVM", "QEMU", "Microsoft Corporation", "Xen" };
                                            foreach (string m_s in strArray)
                                            {
                                                if (m_s == Mftr) { list_mftr = "virtual"; break; }

                                            }
                                            if (list_mftr != "virtual")
                                            {
                                                list_mftr = Mftr;
                                                list_hw = hardware.Result.Trim().Replace("# SMBIOS implementations newer than version 2.6 are not\n# fully supported by this version of dmidecode.\n", "");
                                                list_sn = serial_no.Result.Trim().Replace("# SMBIOS implementations newer than version 2.6 are not\n# fully supported by this version of dmidecode.\n", "");
                                            }

                                            string memory_total = meminfo.Result.Replace(" ", "").Replace("MemTotal:", "").Replace("kB", "");
                                            long mem3 = upper_power_of_two(Convert.ToInt64(memory_total) / 1024);
                                            list_mem = mem3;
                                            int cpucount = 0;
                                            decimal cspeed = 0.0m;
                                            string cpuspeed = "";
                                            using (StringReader reader = new StringReader(cpuinfo.Result))
                                            {
                                                string line = string.Empty;
                                                do
                                                {
                                                    line = reader.ReadLine();
                                                    if (line != null)
                                                    {
                                                        cpucount += 1;
                                                        cpuspeed = Regex.Split(line, "MHz")[0].Trim();
                                                        cspeed = Convert.ToDecimal(cpuspeed) / 1000;
                                                    }

                                                } while (line != null);
                                            }
                                            string cpucores = coreinfo.Result.Replace("Core Count: ", "").Trim();
                                            if (cpucount > 0)
                                            {
                                                list_cpucount = cpucount.ToString(); list_cpuspeed = Convert.ToString(cspeed);
                                                if (cpucores != "") { list_cpucore = cpucores; }
                                            }
                                            all_the_values.Add(new string[] { dev_name, list_mftr, list_hw, list_sn, list_os, list_osver, list_osverno, list_osserial, list_osmftr, list_mem.ToString(), list_cpucount, list_cpucore, list_cpuspeed });

                                            string[] ifaces = Regex.Split(ifconfig.Result, "--\n");

                                            foreach (string iface in ifaces)
                                            {

                                                if (iface.Contains("inet addr"))
                                                {

                                                    string[] line = Regex.Split(iface, "\n");
                                                    string ipv4_address = "", tag = "", mac = "";
                                                    foreach (string ln in line)
                                                    {
                                                        if (ln.Contains("inet addr")) { ipv4_address = ln.Split(':')[1].Split(' ')[0]; }
                                                        if (ln.Contains("Ethernet")) { tag = ln.Split()[0]; mac = Regex.Split(ln, "HWaddr ")[1]; }


                                                    }
                                                    all_the_ip_values.Add(new string[] { ipv4_address, tag, mac, dev_name });


                                                }
                                                if (iface.Contains("inet6 addr"))
                                                {

                                                    string[] line = Regex.Split(iface, "\n");
                                                    string ipv6_address = "", tag = "", mac = "";
                                                    foreach (string ln in line)
                                                    {
                                                        if (ln.Contains("inet6 addr")) { ipv6_address = Regex.Split(ln, "addr: ")[1].Split('/')[0]; }
                                                        if (ln.Contains("Ethernet")) { tag = ln.Split()[0]; mac = Regex.Split(ln, "HWaddr ")[1]; }


                                                    }
                                                    all_the_ip6_values.Add(new string[] { ipv6_address, tag, mac, dev_name });

                                                }
                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        //Console.WriteLine(ex.ToString());
                                        client.Disconnect();
                                        Trace.WriteLine(ex.ToString());
                                    }

                                }
                            }
                            catch (Exception ex) { Trace.WriteLine(ex.ToString()); }
            
                        }, tokenSource.Token);
            task_1.Start();
            task_1.ContinueWith(t => check_linux_progress());
        }

        private void linuxrun_Click(object sender, EventArgs e)
        {



                linuxrun.Enabled = false;

                linux_temp = 0;
                linux_progressbar.Value = 0;
                linux_progress_label.ForeColor = Color.Blue;
                tokenSource = new CancellationTokenSource();
                System.Threading.Tasks.Task task = new System.Threading.Tasks.Task(() =>
                        {
                            int cnt = 0;
                            if (linuxlistradio.Checked)
                            {

                                linux_total_count = linuxlist.GetLineFromCharIndex(linuxlist.TextLength) + 1;
                                linux_progress_label.Text = "Progress: Starting...";
                                linux_cancel.Enabled = true;
                                if (linux_total_count == 1 && linuxlist.Text == "")
                                {
                                    linux_empty_list();
                                }
                                foreach (string c in linuxlist.Lines)
                                {

                                    try
                                    {
                                        if ((c.Trim().CompareTo("")) != 0)
                                        {
                                            gothroughlinux(c.Trim(), linuxuser.Text, linuxpass.Text);
                                        }
                                        else { check_linux_progress(); }
                                    }
                                    catch (Exception ex)
                                    {
                                        Trace.WriteLine(ex.ToString());
                                    }

                                }

                                

                            }
                            else
                            {

                                linux_progress_label.Text = "Progress: Getting the IP List...";
                                try
                                {
                                    List<string> ips = get_ip_list(linuxfrom.Text, linuxto.Text);
                                    linux_total_count = ips.Capacity;
                                    linux_progress_label.Text = "Progress: Starting...";
                                    linux_cancel.Enabled = true;
                                    foreach (string ip in ips)
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
                                    Trace.WriteLine(ex.ToString());
                                    Trace.WriteLine("Please check IP range input values again");

                                    linux_progress_label.ForeColor = Color.Red;
                                    linux_progress_label.Text = "Progress: Error getting the IP List, Please check input...";
                                    linuxrun.Enabled = true;
                                }
                            }
                            cnt += 1;
                        });
                task.Start();

                task.ContinueWith(t => Console.WriteLine("started"));


            
        }


        private void winrange_CheckedChanged(object sender, EventArgs e)
        {
            if (winrange.Checked)
            {
                winfrom.Visible = true;
                winto.Visible = true;
                wintolabel.Visible = true;
                winfromlabel.Visible = true;
                winlist.Visible = false;
            }
        }

        private void check_win_progress()
        {
            win_temp += 1;
            if (win_temp == win_total_count)
            {
                winrunnow.Enabled = true;
                win_cancel.Enabled = false;
                win_cancel.Text = "Cancel";
                win_progressbar.Value = 100;
                win_progress_label.Text = "Progress: " + win_total_count + "/" + win_total_count + ", Finished, Writing to Excel File";
                win_progress_label.ForeColor = Color.Green;
                write_to_excel();
                win_progress_label.Text = "Progress: " + win_total_count + "/" + win_total_count + ", Finished.";
                win_progress_label.ForeColor = Color.Black;
            }
            else if (win_total_count == 0)
            {
                winrunnow.Enabled = true;
                win_cancel.Enabled = false;
                win_cancel.Text = "Cancel";
                win_progressbar.Value = 100;
                win_progress_label.Text = "Progress: " + "Finished";
                win_progress_label.ForeColor = Color.Black;
            }
            else
            {
                try
                {
                    win_progressbar.Value = win_temp * 100 / win_total_count;
                    win_progress_label.Text = "Progress: " + win_temp + "/" + win_total_count;
                }
                catch (Exception ex)
                {
                    win_progressbar.Value = 100;
                    win_progress_label.ForeColor = Color.Red;
                    win_progress_label.Text = "Progress: Error, please check the Log.";
                    Trace.WriteLine(ex.ToString());
                }

            }

        }

        private void win_empty_list()
        {
            winrunnow.Enabled = true;
            win_cancel.Enabled = false;
            win_cancel.Text = "Cancel";
            win_progress_label.Text = "Progress: " + "Empty list";
            win_progress_label.ForeColor = Color.Black;

        }

        private void check_linux_progress() {
            linux_temp += 1;
            if (linux_temp == linux_total_count)
            {
                linuxrun.Enabled = true;
                linux_cancel.Enabled = false;
                linux_cancel.Text = "Cancel";
                linux_progressbar.Value = 100;
                linux_progress_label.Text = "Progress: " + linux_total_count + "/" + linux_total_count + ", Finished";
                write_to_excel();
                linux_progress_label.ForeColor = Color.Black;
                
            }
            else if (linux_total_count == 0)
            {
                linuxrun.Enabled = true;
                linux_cancel.Enabled = false;
                linux_cancel.Text = "Cancel";
                linux_progressbar.Value = 100;
                linux_progress_label.Text = "Progress: " + "Finished";
                linux_progress_label.ForeColor = Color.Black;
            }
            else
            {
                try { linux_progressbar.Value = linux_temp * 100 / linux_total_count;
                linux_progress_label.Text = "Progress: " + linux_temp + "/" + linux_total_count;
                }
                catch (Exception ex)
                {
                linux_progressbar.Value = 100;
                linux_progress_label.ForeColor = Color.Red;
                linux_progress_label.Text = "Progress: Error, please check the Log." ;
                Trace.WriteLine(ex.ToString());
                }
                
            }
        
        }

        private void linux_empty_list()
        {
            linuxrun.Enabled = true;
            linux_cancel.Enabled = false;
            linux_cancel.Text = "Cancel";
            linux_progress_label.Text = "Progress: " + "Empty list";
            linux_progress_label.ForeColor = Color.Black;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://docs.device42.com/open-discovery-client");
        }

        private void linux_cancel_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            linux_progress_label.Text = "Progress: " + "Cancelling....";
            Trace.WriteLine("cancelling.....");
            linux_cancel.Text = "Cancelling...";
            linux_cancel.Enabled = false;
        }

        private void win_cancel_Click(object sender, EventArgs e)
        {
            tokenSource_win.Cancel();
            win_progress_label.Text = "Progress: " + "Cancelling....";
            Trace.WriteLine("cancelling.....");
            win_cancel.Text = "Cancelling...";
            win_cancel.Enabled = false;
        }

        private string Post_to_d42(string URL, string returnValue, string UPLOADdata)
        {
            using (var client = new WebClient())
            {                //Change SSL checks so that all checks pass? 
                System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
                Uri requestUri = new Uri(URL);
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                client.Headers.Add("AUTHORIZATION", returnValue);
                return client.UploadString(requestUri, UPLOADdata);
            }

        }
        private long upper_power_of_two(long v)
        {
            v--;
            v |= v >> 1;
            v |= v >> 2;
            v |= v >> 4;
            v |= v >> 8;
            v |= v >> 16;
            v++;
            return v;

        }
        private  List<string> get_ip_list(string start_ip, string end_ip) {

            System.Net.IPAddress startIP = System.Net.IPAddress.Parse(start_ip);
            System.Net.IPAddress lastIP = System.Net.IPAddress.Parse(end_ip);

                                    byte [] beginIP = startIP.GetAddressBytes();
                                    byte [] endIP = lastIP.GetAddressBytes();
                                    int capacity = 1;
                                    for (int i = 0; i < 4; i++)
                                        capacity *= endIP[i] - beginIP[i] + 1;

                                    List<string> ips = new List<string>(capacity);
                                    for (int i0 = beginIP[0]; i0 <= endIP[0]; i0++)
                                    {
                                        for (int i1 = beginIP[1]; i1 <= endIP[1]; i1++)
                                        {
                                            for (int i2 = beginIP[2]; i2 <= endIP[2]; i2++)
                                            {
                                                for (int i3 = beginIP[3]; i3 <= endIP[3]; i3++)
                                                {
                                                    ips.Add(new IPAddress(new byte[] { (byte)i0, (byte)i1, (byte)i2, (byte)i3 }).ToString());
                                                }
                                            }
                                        }
                                    }

                                    return ips;
    }
        private bool read_from_excel(ExcelWorksheet worksheet, string dev)
        {
            bool dont_have = true;
            
            try
            {
                
                        int row = worksheet.Dimension.End.Row;
                        
                        if (row > 1)
                        {
                            for (int i = 2; i <= row; i++)
                            {
                                
                                if ((worksheet.Cells[i, 1].Value).ToString() == dev) { dont_have = false; break; }
                            }

                        
                        }

                    }
                    catch (Exception ex) { Trace.WriteLine(ex.ToString()); }


            return dont_have;
        }

        private void write_to_excel()
        {
            if (!being_written)
            {
                string f_name;
                if (folder_path == "Default") { f_name = "D42_Device_IP.xlsx"; }
                else { f_name = folder_path + "\\D42_Device_IP.xlsx"; }
                FileInfo newFile = new FileInfo(@f_name);
                try
                {
                    using (ExcelPackage xlPackage = new ExcelPackage(newFile))
                    {
                        being_written = true;
                        ExcelWorksheet worksheet;
                        int row = 2;
                        try
                        {
                            worksheet = xlPackage.Workbook.Worksheets[1];
                            row = worksheet.Dimension.End.Row + 1;
                        }
                        catch (Exception ex) 
                        {
                            Console.WriteLine(ex.ToString()); 
                            worksheet = xlPackage.Workbook.Worksheets.Add("Devices");
                            worksheet.Cells[1, 1].Value = "Device Name";
                            worksheet.Cells[1, 2].Value = "Manufacturer";
                            worksheet.Cells[1, 3].Value = "Hardware Model";
                            worksheet.Cells[1, 4].Value = "Serial #";
                            worksheet.Cells[1, 5].Value = "OS";
                            worksheet.Cells[1, 6].Value = "OS Version";
                            worksheet.Cells[1, 7].Value = "OS Version #";
                            worksheet.Cells[1, 8].Value = "OS Serial #";
                            worksheet.Cells[1, 9].Value = "OS Manufacturer";
                            worksheet.Cells[1, 10].Value = "Memory in MB";
                            worksheet.Cells[1, 11].Value = "CPU Count";
                            worksheet.Cells[1, 12].Value = "Cores per CPU";
                            worksheet.Cells[1, 13].Value = "CPU Speed(GHz)";
                            worksheet.Cells["A1:M1"].Style.Font.Bold = true;
                        }

                        int col = 1;
                        foreach (string[] subList in all_the_values)
                        {
                            if (read_from_excel(worksheet, subList[0]))
                            {
                            foreach (string item in subList)
                            {
                                worksheet.Cells[row, col].Value = item;
                                col += 1;
                            }
                            row += 1;
                            col = 1;
                            }
                        }
                        ExcelWorksheet worksheet_ip;
                        int row_ip = 2;
                        try
                        {
                            worksheet_ip = xlPackage.Workbook.Worksheets[2];
                            row_ip = worksheet_ip.Dimension.End.Row + 1;
                        }
                        catch
                        {
                            worksheet_ip = xlPackage.Workbook.Worksheets.Add("IPv4");
                            worksheet_ip.Cells[1, 1].Value = "IP Address";
                            worksheet_ip.Cells[1, 2].Value = "Interface Name";
                            worksheet_ip.Cells[1, 3].Value = "MAC Address";
                            worksheet_ip.Cells[1, 4].Value = "Device Name";
                            worksheet_ip.Cells["A1:D1"].Style.Font.Bold = true;
                        }

                        int col_ip = 1;
                        foreach (string[] subList in all_the_ip_values)
                        {
                            if (read_from_excel(worksheet_ip, subList[0]))
                            {
                                foreach (string item in subList)
                                {
                                    worksheet_ip.Cells[row_ip, col_ip].Value = item;
                                    col_ip += 1;
                                }
                                row_ip += 1;
                                col_ip = 1;
                            }
                        }
                        ExcelWorksheet worksheet_ip6;
                        int row_ip6 = 2;
                        try
                        {
                            worksheet_ip6 = xlPackage.Workbook.Worksheets[3];
                            row_ip6 = worksheet_ip6.Dimension.End.Row + 1;
                        }
                        catch
                        {
                            worksheet_ip6 = xlPackage.Workbook.Worksheets.Add("IPv6");
                            worksheet_ip6.Cells[1, 1].Value = "IPv6 Address";
                            worksheet_ip6.Cells[1, 2].Value = "Interface Name";
                            worksheet_ip6.Cells[1, 3].Value = "MAC Address";
                            worksheet_ip6.Cells[1, 4].Value = "Device Name";
                            worksheet_ip6.Cells["A1:D1"].Style.Font.Bold = true;
                        }

                        int col_ip6 = 1;
                        foreach (string[] subList in all_the_ip6_values)
                        {
                            if (read_from_excel(worksheet_ip6, subList[0]))
                            {
                                foreach (string item in subList)
                                {
                                    worksheet_ip6.Cells[row_ip6, col_ip6].Value = item;
                                    col_ip6 += 1;
                                }
                                row_ip6 += 1;
                                col_ip6 = 1;
                            }
                        }
                        // set some core property values
                        xlPackage.Workbook.Properties.Title = "D42 Devices and IP Excel Sheet";
                        xlPackage.Workbook.Properties.Author = "Device42 Open Discovery Software";
                        
                        xlPackage.Save();
                        being_written = false;
                    }
                }
                catch( Exception  e)
                {
                    Trace.WriteLine(e.ToString());
                }
            }
            else
            {
                win_progress_label.Text = "Progress: Finished Discovery, Looks like other process is writing to Excel File, Waiting...";
                Thread.Sleep(500);
                write_to_excel();
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.device42.com/product/?od");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/device42/Open-Discovery-Client");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.device42.com/twitter_od/");
        }

        private void file_path_button_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folder_path = folderBrowserDialog1.SelectedPath;
                file_path.Text = "Current folder where file is saved: " + folder_path;
            }
        }

}

}
