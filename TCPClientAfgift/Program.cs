using System;
using System.IO;
using System.Net.Sockets;

namespace TCPClientAfgift
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient clientSocket = new TcpClient("127.0.0.1", 6789);
            Console.WriteLine("Client ready");

            Stream ns = clientSocket.GetStream();  //provides a Stream
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Indtast Elbil eller Personbil\nIndtast: ");
                string lineToSend2 = Console.ReadLine();
                Console.WriteLine("Sender til server: " + lineToSend2);
                sw.WriteLine(lineToSend2);
                

                Console.Write("Indtast Pris\nIndtast: ");
                double lineToSend = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sender til server: " + lineToSend);
                sw.WriteLine(lineToSend);

                string lineReceived = sr.ReadLine();            
                Console.WriteLine("Svar fra server: " + lineReceived);
            }
            Console.ReadLine();
            Console.WriteLine("No more from server. Press Enter");
            clientSocket.Close();
            ns.Close();
        }
    }
}
