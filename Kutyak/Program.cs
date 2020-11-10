using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kutyak
{
    class Program
    {
        static List<KutyaNev> kutyaNevek = new List<KutyaNev>();
        static List<KutyaFajta> kutyafajtak = new List<KutyaFajta>();
        static List<Kutya> kutyak = new List<Kutya>();

        static void KutyaNevekBeolvasas()
        {
            StreamReader be = new StreamReader("KutyaNevek.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyaNevek.Add(new KutyaNev(
                  Convert.ToInt32(adat[0]),
                  adat[1]
                ));
            }

            be.Close();
        }
        static void Harmadik()
        {
            Console.WriteLine($"3.feladat: Kutyanevek száma: {kutyaNevek.Count()}");
        }
        static void KutyaFajtakBeolvasas()
        {
            StreamReader be = new StreamReader("KutyaFajtak.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyafajtak.Add(new KutyaFajta(Convert.ToInt32(adat[0]),adat[1],adat[2]));
            }

            be.Close();
        }
        static void Otodik()
        {
            StreamReader be = new StreamReader("KutyaFajtak.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyak.Add(new Kutya(int.Parse(adat[0]),int.Parse(adat[1]),int.Parse(adat[2]),int.Parse(adat[3]),adat[4]));
            }

            be.Close();
        }
        public static void Main(string[] args)
        {
            KutyaNevekBeolvasas();
            Harmadik();
            KutyaFajtakBeolvasas();

            Console.ReadKey();
        }
    }
}
