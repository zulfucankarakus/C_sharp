using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaUygulamasi_G024
{
    class Sinema
    {

        public string FilmAdi { get; set; }
        public int Kapasite { get; }
        public float TamBiletFiyati { get; }
        public float YarimBiletFiyati { get; }
        public int ToplamTamBiletAdedi { get; private set; }
        public int ToplamYarimBiletAdedi { get; private set; }
        public float Ciro { get
            {
                float sonuc= this.ToplamTamBiletAdedi * this.TamBiletFiyati + this.ToplamYarimBiletAdedi * this.YarimBiletFiyati;
                return sonuc;
            }
        }

        public Sinema(string filmadı,int kapasite,int tambiletfiyatı,int yarımbiletfiyatı)
        {
            this.FilmAdi = filmadı;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tambiletfiyatı;
            this.YarimBiletFiyati = yarımbiletfiyatı;
        }


        public void BiletSat(int tamBiletAdedi, int yarımBiletAdedi)
        {
            if (BosKoltukSayısı()>=(tamBiletAdedi+yarımBiletAdedi))
            {
                this.ToplamTamBiletAdedi += tamBiletAdedi;
                this.ToplamYarimBiletAdedi += yarımBiletAdedi;

                //CiroHesapla();
                Console.WriteLine("İşlem gerçekleştirildi");
                
            }
            else
            {
                Console.WriteLine("Yeterli koltuk yok.En fazla" +BosKoltukSayısı()+ "adet bilet satılabilir.");
            }
            
        }

        public void Biletİade(int tamBiletAdedi, int yarımBiletAdedi)
        {
            if (tamBiletAdedi<=ToplamTamBiletAdedi&&yarımBiletAdedi<=ToplamYarimBiletAdedi)
            {
                this.ToplamTamBiletAdedi -= tamBiletAdedi;
                this.ToplamYarimBiletAdedi -= yarımBiletAdedi;

                //CiroHesapla();
            }
            else
            {
                Console.WriteLine("Bu kadar bilet iadesi alınamaz");
            }
            
        }

        //private void CiroHesapla()
        //{
            //this.Ciro = this.ToplamTamBiletAdedi * this.TamBiletFiyati + this.ToplamYarimBiletAdedi * this.YarimBiletFiyati;
        //}

        public int BosKoltukSayısı()
        {
            int boskoltuk = this.Kapasite - (this.ToplamYarimBiletAdedi + this.ToplamTamBiletAdedi);
            return boskoltuk;
        }
    }
}
