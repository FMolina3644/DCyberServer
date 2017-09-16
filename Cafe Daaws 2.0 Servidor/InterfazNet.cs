using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Servidor
{
    public class InterfazNet
    {

        public static bool ValidarConexion(TcpClient Cliente)
        {
            try
            {
                if (Cliente.Client.LocalEndPoint == null) { return false; }
                bool Part1 = Cliente.Client.Poll(10, SelectMode.SelectRead);
                bool Part2 = Cliente.Client.Available == 0;

                if (Part1 && Part2)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static void Send(TcpClient Cliente, String Dato)
        {
            try
            {
                NetworkStream Net = Cliente.GetStream();
                StreamWriter NetWriter = new StreamWriter(Net);
                NetWriter.WriteLine(Dato);
                NetWriter.Flush();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar no hay socket, El Equipo Puede Estar Desconectado ó Apagado");
            }
        }

        public static void Send(TcpClient Cliente, Object Dato)
        {
            NetworkStream Net = Cliente.GetStream();
            StreamWriter NetWriter = new StreamWriter(Net);
            NetWriter.WriteLine(Dato);
            NetWriter.Flush();
        }

        public static String Get(TcpClient Cliente)
        {
            try
            {
                NetworkStream Net = Cliente.GetStream();
                StreamReader NetReader = new StreamReader(Net);
                return NetReader.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al recibir");
                return "";
            }
        }

        public static void Get(TcpClient Cliente, ref object Objeto)
        {
            NetworkStream Net = Cliente.GetStream();
            StreamReader NetReader = new StreamReader(Net);
            Objeto = NetReader.ReadLine();
        }

        public static void Get(TcpClient Cliente, ref String Dato)
        {
            NetworkStream Net = Cliente.GetStream();
            StreamReader NetReader = new StreamReader(Net);
            Dato = NetReader.ReadLine();
        }

    }
}
