using System.Net.Sockets;
using System.Text;

namespace OverTheTop;

public static class VideoHandler
{
    static List<UdpClient> UdpClients = new();
    static Dictionary<string, string> ConnectedClients = new();
    static int Port = 11000;

    public static void NewClient(string ip)
    {
        UdpClient client = null;
        lock (ConnectedClients)
        {
            if (!ConnectedClients.ContainsKey(ip))
            {
                client = new();
                client.Connect(ip, Port++);
                ConnectedClients.Add(ip, ip);
            }
        }
        if (client != null)
            lock (UdpClients)
            {
                UdpClients.Add(client);
            }
    }
    public static void Send()
    {
        byte[] enviar = Encoding.ASCII.GetBytes("A enviar bytes");
        while (true)
            lock (ConnectedClients)
            {
                UdpClients.ForEach(x => x.Send(enviar, enviar.Length));
            }
    }
}
