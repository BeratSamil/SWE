//The concepts of OOP in C#
using System;
namespace OOP_in_Csharp
{
    public class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;
        public static int ctr = 0;

        public Computer(string bn, string ip, string os)
        {
            _BIOSname = bn;
            _ipadress = ip;
            _OS = os;
            ctr += 1;
        }

        public string BiosName
        {
            get { return _BIOSname; }
            set { _BIOSname = value; }
        }

        public string IpAdress
        {
            get { return _ipadress; }
            set { _ipadress = value; }
        }

        public string OS
        {
            get { return _OS; }
            set { _OS = value; }
        }

    }




    class Program
    {
        public static void Main(string[] args)
        {
            /*Computer comp1 = new("alfa", "10.0.0.23", "Windows 11");
            Console.WriteLine(comp1.BiosName);
            Computer comp2 = new("excalibur", "10.0.0.24", "Pop_OS! 22.04");
            Console.WriteLine("{0},{1},{2}", comp2.BiosName, comp2.IpAdress, comp2.OS);*/

            /*Computer[] net = new Computer[4];*/

            List<Computer> listComp = new List<Computer>();
            int numOfComp = 5;


            for (int i = 0; i < numOfComp; i++)
            {
                Computer comp = new Computer("comp" + i.ToString(), "10.0.20." + i.ToString(), "Win10");
                listComp.Add(comp);
            }


            for (int i = 0; i < listComp.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}", listComp[i].BiosName, listComp[i].IpAdress, listComp[i].OS);
            }

            Console.WriteLine("We ave {0} computers in our Network.",Computer.ctr);
        }
    }




}

/*

           Computer[] net = new Computer[4];

           for (int i = 0; i < net.Length; i++)
           {
               net[i] =
                 new Computer("comp" + i.ToString(),
                       "10.0." + getNum() + "." + getNum(), "Win10");
           }

           for (int i = 0; i < net.Length; i++)
           {
               Console.WriteLine("{0} {1}", net[i]._BIOSname, net[i]._ipadress);
           }

           */

/*
  static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }
 
 
 */