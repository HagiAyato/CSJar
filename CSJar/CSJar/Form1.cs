using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSJar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (ConnectJar.Excecute(textBox1.Text))
            {
                MessageBox.Show("jar連携処理成功");
            }
            else
            {
                MessageBox.Show("jar連携処理失敗");
            }
            button1.Enabled = true;
        }
    }
}
