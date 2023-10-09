using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ortalama;
            ortalama=Convert.ToSingle(txtOrtalama.Text);
            if (ortalama<0)
            {
                lblSonuc.Text = "Negatif Değer Giremezsin";
            }
            else if (ortalama<50)
            {
                lblSonuc.Text = "Kaldınız";

            }
            else if (ortalama<70)
            {
                lblSonuc.Text = "Geçtin";
            }
            else if (ortalama<85)
            {
                lblSonuc.Text = "Teşekkür Belgesi Aldın";

            }
            else if (ortalama<=100)
            {
                lblSonuc.Text = "Takdir Belgesi Aldın ";
            }
            else
            {
                lblSonuc.Text = "Düzgün Not Yaz";
            }
        }
    }
}
