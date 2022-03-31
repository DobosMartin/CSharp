using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpelCLI
{
    class auto 
    {
        public string neve;
        public int gyartasiev, ulesekszama, ccm, gyorsulas, suly;

        public auto(string sor) 
        {
            string[] s = sor.Split('\t');
            neve = s[0];
            gyartasiev = Convert.ToInt32(s[1]);
            ulesekszama = Convert.ToInt32(s[2]);
            ccm = Convert.ToInt32(s[3]);
            gyorsulas = Convert.ToInt32(s[4]);
            suly = Convert.ToInt32(s[5]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("opel.txt")
        }
    }
}
