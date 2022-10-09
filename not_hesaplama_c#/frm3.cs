using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_hesaplama
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?", "çıkış uyarısı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (exit == DialogResult.OK) Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double average, mPercent, bPercent, midterm, but;
            try
            {
                midterm = double.Parse(textBox1.Text);
                but = double.Parse(textBox2.Text);
                mPercent = double.Parse(comboBox1.Text.Trim(new Char[] { '%' }));
                bPercent = double.Parse(comboBox2.Text.Trim(new Char[] { '%' }));

                if (midterm > 100) MessageBox.Show("Vize Notu Hatalıdır, Lütfen 0 ile 100 Arasında Bir Değer Giriniz!");
                else if (but > 100) MessageBox.Show("Final Notu Hatalıdır, Lütfen 0 ile 100 Arasında Bir Değer Giriniz!");
                else
                {
                    average = midterm / 100 * mPercent + but / 100 * bPercent;
                    label5.Text = average.ToString();
                    if (average >= 90)
                    {
                        label6.Text = "AA";
                    }
                    else if (average >= 85 && average < 90)
                    {
                        label6.Text = "BA";
                    }
                    else if (average >= 80 && average < 85)
                    {
                        label6.Text = "BB";
                    }
                    else if (average >= 75 && average < 80)
                    {
                        label6.Text = "CB";
                    }
                    else if (average >= 70 && average < 75)
                    {
                        label6.Text = "CC";
                    }
                    else if (average >= 65 && average < 70)
                    {
                        label6.Text = "DC";
                    }
                    else if (average >= 60 && average < 65)
                    {
                        label6.Text = "DD";
                    }
                    else if (average >= 50 && average < 60)
                    {
                        label6.Text = "FD";
                    }
                    else if (average < 50)
                    {
                        label6.Text = "FF";
                    }
                    if (average < 50 || but < 50)
                    {
                        label5.ForeColor = Color.Red;
                        label6.ForeColor = Color.Red;
                    }
                    else
                    {
                        label5.ForeColor = Color.Green;
                        label6.ForeColor = Color.Green;
                    }

                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı! Lütfen Bütün Alanları Doldurduğunuzdan Emin Olunuz...", "Hatalı İşlem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) comboBox1.Text = comboBox1.Items[8].ToString();
            if (comboBox2.SelectedIndex == 1) comboBox1.Text = comboBox1.Items[7].ToString();
            if (comboBox2.SelectedIndex == 2) comboBox1.Text = comboBox1.Items[6].ToString();
            if (comboBox2.SelectedIndex == 3) comboBox1.Text = comboBox1.Items[5].ToString();
            if (comboBox2.SelectedIndex == 4) comboBox1.Text = comboBox1.Items[4].ToString();
            if (comboBox2.SelectedIndex == 5) comboBox1.Text = comboBox1.Items[3].ToString();
            if (comboBox2.SelectedIndex == 6) comboBox1.Text = comboBox1.Items[2].ToString();
            if (comboBox2.SelectedIndex == 7) comboBox1.Text = comboBox1.Items[1].ToString();
            if (comboBox2.SelectedIndex == 8) comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) comboBox2.Text = comboBox2.Items[8].ToString();
            if (comboBox1.SelectedIndex == 1) comboBox2.Text = comboBox2.Items[7].ToString();
            if (comboBox1.SelectedIndex == 2) comboBox2.Text = comboBox2.Items[6].ToString();
            if (comboBox1.SelectedIndex == 3) comboBox2.Text = comboBox2.Items[5].ToString();
            if (comboBox1.SelectedIndex == 4) comboBox2.Text = comboBox2.Items[4].ToString();
            if (comboBox1.SelectedIndex == 5) comboBox2.Text = comboBox2.Items[3].ToString();
            if (comboBox1.SelectedIndex == 6) comboBox2.Text = comboBox2.Items[2].ToString();
            if (comboBox1.SelectedIndex == 7) comboBox2.Text = comboBox2.Items[1].ToString();
            if (comboBox1.SelectedIndex == 8) comboBox2.Text = comboBox2.Items[0].ToString();
        }

        private void frm3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("%10");
            comboBox1.Items.Add("%20");
            comboBox1.Items.Add("%30");
            comboBox1.Items.Add("%40");
            comboBox1.Items.Add("%50");
            comboBox1.Items.Add("%60");
            comboBox1.Items.Add("%70");
            comboBox1.Items.Add("%80");
            comboBox1.Items.Add("%90");

            comboBox2.Items.Add("%10");
            comboBox2.Items.Add("%20");
            comboBox2.Items.Add("%30");
            comboBox2.Items.Add("%40");
            comboBox2.Items.Add("%50");
            comboBox2.Items.Add("%60");
            comboBox2.Items.Add("%70");
            comboBox2.Items.Add("%80");
            comboBox2.Items.Add("%90");
        }
    }
}
