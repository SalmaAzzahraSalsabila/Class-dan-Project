using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan2
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class mahasiswa 
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //mengeset nilai properties objek saya dan kamu 
            saya.NIM = "18.11.2247";
            saya.NAMA = "Salma Azzahra Salsabila";
            saya.IPK = 3.95f;

            kamu.NIM = "18.11.2254";
            kamu.NAMA = "Aulia Widi Pradiktya";
            kamu.IPK = 3.70f;

            //memanggil method registrasi dan isi krs 
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
