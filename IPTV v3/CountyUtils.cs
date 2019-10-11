using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IPTV_v3
{
    class CountyUtils
    {
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }


        public static bool CheckEthernet()
        {
            foreach (System.Net.NetworkInformation.NetworkInterface net in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if (net.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up && net.NetworkInterfaceType.ToString() == "Ethernet")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
