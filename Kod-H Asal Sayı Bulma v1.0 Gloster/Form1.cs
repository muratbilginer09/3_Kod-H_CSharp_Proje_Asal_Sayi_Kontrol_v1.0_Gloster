using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kod_H_Asal_Sayı_Bulma_v1._0_Gloster
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        private int x;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                x = int.Parse(textBox1.Text);

                if (x==1)
                {
                    textBox2.Text = "Asal Değildir";
                }

                else if (x==2)
                {
                    textBox2.Text = "Asaldır";
                }

                else
                {
                    for (int i = 2; i < x; i++)
                    {
                        if (x % i == 0)
                        {
                            textBox2.Text = "Asal Değildir";
                            break;
                        }

                        else
                        {

                            textBox2.Text = "Asaldır";

                        }
                    }
                }
                }
                
            catch (Exception)
            {

                MessageBox.Show("Sadece sayı girişi yapabilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
