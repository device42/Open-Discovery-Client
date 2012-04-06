# Device42 Open Discovery Client
A .net based auto-discovery client by device42 Team that would enumerate windows and linux servers in your network and create a excel sheet with  3 tabs:
   1.device info(name, OS, OS version, OS version number, Hardware model, Hardware manufacturer and Hardware serial number)
   2. IPv4 (IP address, label, mac address, device name)
   3. IPv6 (IP address, label, mac address, device name)
   
Works with most windows workstations and servers. 
Tested on Redhat, fedora and ubuntu linux distributions.
No agent to install on remote devices, uses powershell for windows and ssh for linux to collect information.

csharp source code is provided here. For ironpython script and other dependencies, download the binaries at [DOWNLOAD](http://www.device42.com/open-discovery-client)

## Requirements
-----------------------------
 * Microsoft .Net Framework 4
 * Powershell 2.0
 * IronPython 2.7

## Install
-----------------------------
Please see [INSTALL](https://docs.device42.com/open-discovery-client/open-discovery-client-installation/)


## Documentation
-----------------------------
Please see [Documentation](https://docs.device42.com/open-discovery-client/)