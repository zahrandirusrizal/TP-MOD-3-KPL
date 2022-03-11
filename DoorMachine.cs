using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD3
{
    public class DoorMachine
    {
        public enum DoorState { Terkunci, Terbuka};
        public enum Aksi { BukaPintu, KunciPintu};

        public class Transisi
        {
            public DoorState KeadaanPintuSebelum;
            public DoorState KeadaanPintuSetelah;
            public Aksi AksiPintu;

            public Transisi(DoorState KeadaanPintuSebelum,DoorState KeadaanPintuSetelah, Aksi AksiPintu)
            {
                this.KeadaanPintuSebelum = KeadaanPintuSebelum;
                this.KeadaanPintuSetelah = KeadaanPintuSetelah;
                this.AksiPintu = AksiPintu;
            }
        }

        Transisi[] daftarAksi = { 
            new Transisi(DoorState.Terbuka, DoorState.Terkunci, Aksi.KunciPintu),
            new Transisi(DoorState.Terkunci, DoorState.Terbuka,  Aksi.BukaPintu)
        };

        public DoorState PintuSaatIni = DoorState.Terkunci;

        public DoorState changeState(DoorState statusPintu, Aksi aksiPintu)
        {
            DoorState nextState = statusPintu;

            for(int i = 0; i < daftarAksi.Length; i++)
            {
                if(daftarAksi[i].KeadaanPintuSebelum == statusPintu && daftarAksi[i].AksiPintu == aksiPintu)
                {
                    nextState = daftarAksi[i].KeadaanPintuSetelah;
                }
            }
            return nextState;
        }

        public void aktivasiAksi(Aksi aksi)
        {
            DoorState saat_ini = changeState(PintuSaatIni, aksi);
            PintuSaatIni = saat_ini;
        }

        public DoorMachine()
        {
        }
    }
}
