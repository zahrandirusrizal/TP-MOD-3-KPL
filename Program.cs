// See https://aka.ms/new-console-template for more informatio



using System;

namespace TPMOD3
{
   class Program
    {
        static void  Main(string[] args)
        {
            KodePos.Kelurahan kelurahan_masukan = KodePos.Kelurahan.Batununggal;
            System.Console.WriteLine(KodePos.getKodePos(kelurahan_masukan));


        }
    }


}
