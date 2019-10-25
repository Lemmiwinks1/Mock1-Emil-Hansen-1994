using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Skat;

namespace TCPServerAfgift
{
    class Program
    {
        static void Main(string[] args)
        {
     
            IPAddress ip = IPAddress.Parse("127.0.0.1");

            TcpListener serverSocket = new TcpListener(ip, 6789);
   
            serverSocket.Start();
            Console.WriteLine("Server started");

            TcpClient connectionSocket = serverSocket.AcceptTcpClient();
         
            Console.WriteLine("Server activated");

            Stream ns = connectionSocket.GetStream();
        

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            
            string message2 = sr.ReadLine();
            string message = sr.ReadLine();
            double answer = 00.0;
            double pris = Convert.ToDouble(message);


            if (message2 == "Personbil")
            {
                if (pris < 200000)
                {
                    Afgift.BilAfgift(pris);
                }
                else if (pris > 200000)
                {
                    Afgift.BilAfgift(pris);
                }

                Console.WriteLine("Client: " + Afgift.BilAfgift(pris));
                answer = Afgift.BilAfgift(pris);
                sw.WriteLine(answer);
                
            }
            else if (message2 == "Elbil")
            {
                

                if (pris < 200000)
                {
                    Afgift.ElBilAfgift(pris);
                }
                else if (pris > 200000)
                {
                    Afgift.ElBilAfgift(pris);
                }

                Console.WriteLine("Client: " + Afgift.ElBilAfgift(pris));
                answer = Afgift.ElBilAfgift(pris);
                sw.WriteLine(answer);
                
            }
            Console.ReadLine();

            ns.Close();
            connectionSocket.Close();
            serverSocket.Stop();
        }
    }
}
