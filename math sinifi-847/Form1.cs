using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sinifi_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToSingle(txtSayi.Text); //sayısal olarak texti çevirdik

            //işlemler
            double sayiMutlak = Math.Abs(sayi);
            double sayiUs = Math.Pow(sayi, 2); //txt içindeki sayının kuresi(2. kuvvet)
            double sayiKarekok = Math.Sqrt(sayi);
            double sayiYukariYuvarla = Math.Ceiling(sayi);
            double sayiAsagiYuvarla = Math.Floor(sayi);
            double sayiYuvarla = Math.Round(sayi);
            //Round, Floor, Ceil



            //sonuçları yazdır
            lblMutlakDeger.Text = "sayının mutlak değeri:" + sayiMutlak.ToString();
            lblUst.Text = "sayının kuvveti:" + sayiUs.ToString();
            lblKok.Text = "sayının kare kökü:" + sayiKarekok.ToString();
            lblYukari.Text = "sayını yukarı yuvarla:" + sayiYukariYuvarla.ToString();
            lblAsagi.Text = "sayı aşağı yuvarla:" + sayiAsagiYuvarla.ToString();
            lblYuvarlama.Text = "sayı yuvarla:" + sayiYuvarla.ToString();
        }
    }
}
