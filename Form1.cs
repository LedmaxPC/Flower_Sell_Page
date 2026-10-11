using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal a = int.Parse(maskedTextBox1.Text);
            decimal b = decimal.Parse(textBox2.Text);
            decimal c = a * b;
            
            if (textBox1.Text != "" && !string.IsNullOrEmpty(maskedTextBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {

                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!");
                }

                a = decimal.Parse(maskedTextBox1.Text);
                b = decimal.Parse(textBox2.Text);

                if (a <= 0 || b <= 0)
                {
                    MessageBox.Show("Say və qiymət mənfi və ya sıfır ola bilməz!");
                }

                c = a * b;

                dataGridView1.Rows.Add(textBox1.Text.Trim(),a.ToString(),b.ToString("F2"),c.ToString("F2"));

                decimal toplamGelir = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        toplamGelir += Convert.ToDecimal(row.Cells["fullprize"].Value);
                    }
                }

                label4.Text = "Toplam gəlir: " + toplamGelir.ToString("F2");
                textBox1.Clear();
                maskedTextBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Çıxış edilsinmi?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

         private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
         {

         }

         private void label4_Click(object sender, EventArgs e)
         {

         }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
