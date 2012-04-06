# Device42 Open Discovery Client
A .net based auto-discovery client provided by device42 Team that would enumerate windows and linux servers in your network and create a excel sheet with  3 tabs:

    device info(name, OS, OS version, OS version number, Hardware model, Hardware manufacturer and Hardware serial number)
    IPv4 (IP address, label, mac address, device name)
    IPv6 (IP address, label, mac address, device name)
   
Works with most windows workstations and servers. 
Tested on Redhat, fedora and ubuntu linux distributions.


No agent to install on remote devices, uses powershell for windows and ssh for linux to collect information.

csharp source code is provided here. For ironpython script and other dependencies, download the binaries at [Download](http://www.device42.com/open-discovery-client).


To create complete visual studio 2010 project, get the project folder from here and drop binary dependencies from download link into bin\debug folder.


## Requirements
-----------------------------
 * Microsoft .Net Framework 4
 * Powershell 2.0
 * IronPython 2.7

## Install
-----------------------------
Please see [Install](https://docs.device42.com/open-discovery-client/open-discovery-client-installation/)


## Documentation
-----------------------------
Please see [Documentation](https://docs.device42.com/open-discovery-client/)