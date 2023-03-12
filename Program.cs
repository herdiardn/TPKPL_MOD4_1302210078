using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_1302210078
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            int getKodePos = KodePos.getKodePos(KodePos.Kelurahan.Batununggal);
            Console.WriteLine("Kode pos Batununggal adalah :");
            Console.WriteLine(getKodePos);
            Console.WriteLine();
        }
    }
    public class KodePos
    {
        public enum Kelurahan { Batununggal, Kujangsari, Mengger, Weters, Cijaura, Jatisari, Margasari, Sekajati, Kebonwaru, Maleer, Samoja }
        public static int getKodePos(Kelurahan kel)
        {
            int[] kodepos = { 40266, 40287, 40256, 40287, 40286, 40272, 40274, 40273 };
            return kodepos[(int)kel];
        }
    }
}
