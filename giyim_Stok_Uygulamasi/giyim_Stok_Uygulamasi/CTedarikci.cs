using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giyim_Stok_Uygulamasi
{
    class CTedarikci : CKullanicilar
    {
        private int siparis_adet;

        private CFatura taleb_Karsila(int siparis_adet, string ad, string soyad, Category Kotegori, int beden) 
        {
            CFatura fatura = new CFatura();

            return fatura;
        }

        private int iade_Karsila(int fatura_no)
        {
            
            return 0;
        }

        private void fatura_olustur()
        {
            
        }
    }
}
