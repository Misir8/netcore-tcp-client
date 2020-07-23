using System;
using System.Net.Sockets;

namespace TCPClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hostname: ");
            string host = Console.ReadLine();
            Console.WriteLine("Port: ");
            int port;
            string portInput = Console.ReadLine();
            int.TryParse(portInput, out port);
           

            try
            {
                
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(host, port);
                Console.WriteLine("The connection was successful");
                tcpClient.Close();
                Console.WriteLine("The end connection");
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {

                Console.WriteLine($"Exception", e.Message);
            }
        }
    }
}
