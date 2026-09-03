using System;
using System.IO;
using System.Net.Sockets;

class Cliente
{
    static void Main()
    {
        Console.WriteLine("Conectando al servidor...");
        TcpClient client = new TcpClient("192.168.202.57", 5000);

        StreamWriter writer = new StreamWriter(client.GetStream());
        writer.WriteLine("Hola!");
        writer.Flush();

        writer.Close();
        client.Close();
    }
}
