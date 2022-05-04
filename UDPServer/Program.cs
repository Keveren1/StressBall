using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("UDP Server");

using (UdpClient socket = new UdpClient())
using (HttpClient client = new HttpClient())
{
    {
        IPEndPoint clientEndPoint = null;
        socket.Client.Bind(new IPEndPoint(IPAddress.Any, 10100));
        //
        while (true)
        {
            byte[] data = socket.Receive(ref clientEndPoint);
        
            string message = Encoding.UTF8.GetString(data);
        
            Console.WriteLine("Server received: " + message);
        
            HttpContent content = new StringContent(message, Encoding.UTF8, "application/json");
            client.PostAsync("https://localhost:7028/api/Sensor", content);
            
            socket.Send(data, data.Length, clientEndPoint); 
        }
    }
}