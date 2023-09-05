using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araclar
{
    public partial class KayıtFormu : Form
    {
        public KayıtFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add( textBox1.Text +" " + textBox2.Text + "  " + maskedTextBox1.Text + " " +  maskedTextBox2.Text + "  "  + dateTimePicker1.Text + " Tarihinde Kaydedildi.");
        }
    }
}
