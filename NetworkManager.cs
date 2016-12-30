using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class NetworkManager
{
    UdpClient udpClient;

    public NetworkManager()
    {
        udpClient = new UdpClient();
        udpClient.ReceiveAsync((UdpReceiveResult resutl) => {

        });
    }
    
}