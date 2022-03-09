using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SERVBol3_Ejer3
{
    class Program
    {
        // static Cliente client = new Cliente();
        private static readonly object l = new object();
        static List<Cliente> clientecitos = new List<Cliente>();
        

        static void hiloCliente(object trueCliente)
        {
            Cliente cliente = (Cliente)trueCliente;
            string mensaje;
            string userName = "";
            bool apagar = false;
            IPEndPoint ieCliente;
            // Socket socket = (Socket)trueCliente;
            Socket socket = cliente.Socket;
           // ieCliente = (IPEndPoint)socket.RemoteEndPoint;
            ieCliente = (IPEndPoint)cliente.Socket.RemoteEndPoint;
            cliente.Ip = ieCliente;
            Console.WriteLine("Connected with client {0} at port {1}", ieCliente.Address, ieCliente.Port);
            Console.WriteLine("Connected with client {0} at port {1}", cliente.Ip.Address, cliente.Ip.Port);
            //using (NetworkStream ns = new NetworkStream(socket))
            using (NetworkStream ns = new NetworkStream(cliente.Socket))
            using (StreamReader sr = new StreamReader(ns))
           // using (StreamWriter sw = new StreamWriter(ns))
            using (cliente.Mensaje= new StreamWriter(ns))
            {

                string welcome = "Welcome to this great Thing";
                //sw.WriteLine(welcome);
                //sw.Flush();
                cliente.Mensaje.WriteLine(welcome);
                cliente.Mensaje.Flush();

                //sw.WriteLine("Inserte un nombre de usuario por fi :C");
                cliente.Mensaje.WriteLine("Inserte un nombre de usuario por fi :c");
                //sw.Flush();
                cliente.Mensaje.Flush();
                //userName = sr.ReadLine();
                cliente.UserName = sr.ReadLine();

                Console.WriteLine(userName + "    " + socket + "          " + ieCliente);
                //cliente = ClienteShokan(userName, socket, ieCliente);
                clientecitos.Add(cliente);

                //cliente.Mensaje = sw;
                lock (l)
                {
                    if (cliente.UserName != null)
                    {
                        foreach (Cliente conectado in clientecitos)
                        {
                            //conectado.Mensaje.WriteLine("{0}@{1};{2} se ha conectado", userName, ieCliente.Address, ieCliente.Port);
                            conectado.Mensaje.WriteLine("{0}@{1};{2} se ha conectado", cliente.UserName, cliente.Ip.Address, cliente.Ip.Port);
                            conectado.Mensaje.Flush();
                        }
                    }
                }

                while (!apagar)
                {
                    try
                    {
                        mensaje = sr.ReadLine();

                        if (mensaje != null)
                        {
                            lock (l)
                            {
                                switch (mensaje)
                                {
                                    case "#salir":
                                       apagar = Salir(ieCliente,clientecitos);
                                        break;
                                    case "#lista":
                                        foreach (Cliente nombre in clientecitos)
                                        {
                                            Console.WriteLine(clientecitos.Count());
                                            //  sw.WriteLine(nombre.UserName + " Conectado");
                                            // sw.Flush();
                                            cliente.Mensaje.WriteLine(nombre.UserName + " Conectado");
                                        }
                                        break;
                                    default:
                                      //  Console.WriteLine("{0} dice: {1}", ieCliente.Address, mensaje);
                                        Console.WriteLine("{0} dice: {1}", cliente.Ip.Address, mensaje);
                                        foreach (Cliente mesage in clientecitos)
                                        {

                                           // if (sw != mesage.Mensaje)
                                            if(cliente.Mensaje != mesage.Mensaje)
                                            {
                                                mesage.Mensaje.WriteLine("{0}@{1} dice: {2}", cliente.UserName,
                                                                         cliente.Ip.Address, mensaje);
                                                mesage.Mensaje.Flush();
                                            }
                                        }
                                        break;
                                }
                            }
                        }
                        else
                        {
                           apagar = Salir(ieCliente,clientecitos);
                        }
                    }
                    catch (IOException)
                    {
                       apagar = Salir(ieCliente,clientecitos);
                       break;
                    }
                }
                Console.WriteLine("Finished Connection with {0}: {1}", ieCliente.Address, ieCliente.Port);
            }
         
            socket.Close();
        }
        public static bool Salir(IPEndPoint ieCliente, List<Cliente> clientecitos)
        {
            //Console.WriteLine(clientecitos.Count());
            for (int i = clientecitos.Count - 1; i >= 0; i--)
            {
                if (ieCliente.Port == clientecitos[i].Ip.Port)
                {
                    if (clientecitos[i].Ip.Port != ieCliente.Port)
                    {
                        clientecitos[i].Mensaje.WriteLine("{0}@{1} se desconectó", clientecitos[i].UserName, clientecitos[i].Ip);
                    }
                    clientecitos[i].Socket.Close();
                    clientecitos[i].Mensaje.Close();
                    clientecitos.RemoveAt(i);
                    //Console.WriteLine(clientecitos.Count());
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Cliente clienteDeVerdad;
            int puerto = 10823;
            while (true)
            {
                IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto);
                //Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                using (Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                ProtocolType.Tcp))
                {
                    try
                    {
                        s.Bind(ie);
                    }
                    catch (SocketException e) when (e.ErrorCode == (int)SocketError.AddressAlreadyInUse)
                    {
                        puerto++;
                        ie = new IPEndPoint(IPAddress.Any, puerto);
                        s.Bind(ie);
                    }

                     s.Listen(10);
                    
                    Console.WriteLine("Server waiting at port {0}", ie.Port);
                    while (true)
                    {
                        clienteDeVerdad = new Cliente(s.Accept(), ie);
                        clienteDeVerdad.Socket = s.Accept();
                       
                        Thread hilo = new Thread(hiloCliente);
                        hilo.Start(clienteDeVerdad);
                    }
                }
            }

        }
    }
}
