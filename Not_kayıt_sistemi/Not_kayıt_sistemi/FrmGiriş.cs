using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_kayıt_sistemi
{
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmÖğrenciDetay frm= new FrmÖğrenciDetay();
            frm.numara = maskedTextBox1.Text;
            frm.Show();
            // this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text=="1111")
            { 
                FrmÖğretmenDetay fr=new FrmÖğretmenDetay();
                fr.Show();
                    
                    
             }
        }
    }
}
