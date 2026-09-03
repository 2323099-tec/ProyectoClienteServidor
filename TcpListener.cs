using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class Servidor
{
    static void Main()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 5000);
        server.Start();
        Console.WriteLine("Servidor escuchando en el puerto 5000...");

        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("Cliente conectado!");

        StreamReader reader = new StreamReader(client.GetStream());
        string mensaje = reader.ReadLine();
        Console.WriteLine("Recibido: " + mensaje);

        reader.Close();
        client.Close();
        server.Stop();
    }
}
