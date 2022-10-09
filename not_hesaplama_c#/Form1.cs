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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?","çıkış uyarısı",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (exit == DialogResult.OK) Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                frm3 f3 = new frm3();
                f3.ShowDialog();
            }
            else if(radioButton2.Checked==true)
            {
                frm2 f2 = new frm2();
                f2.ShowDialog();
            }

        }
    }
}
