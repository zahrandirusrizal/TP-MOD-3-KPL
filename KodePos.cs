using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD3
{
    public class KodePos
    { 
        public enum Kelurahan { 
            Batununggal,
            Kujangsari,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwaru,
            Maleer,
            Samoja
        };

        public KodePos()
        {
        }

        public static int getKodePos(Kelurahan kelurahan_masukan)
        {
            int[] arrayofKodePoss = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            int keluaran = (int)kelurahan_masukan;
            return arrayofKodePoss[keluaran];
        }
    }
}
