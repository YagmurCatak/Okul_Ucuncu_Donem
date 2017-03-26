using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giyim_Stok_Uygulamasi
{
    class CKullanicilar
    {
        private
        CPhoneNumber TelNu;
        string m_ad;
        string m_soyad;
        string tc_number;
        string email;
        string sifre;
        int fatura_no;
       
        private Boolean stokArttir(CUrun urun, int adet)
        {
            if (adet > 0)
                return false;
            else
                return true;
          // Doldurma kismini bak. 
        }

        private Boolean stokAzalt(CUrun urun, int adet)
        {
            if (adet > 0)
                return false;
            else
                return true;
            // Doldurma kismini bak. 
        }

    }
}
