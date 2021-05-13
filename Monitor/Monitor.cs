using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    public partial class textline : Form
    {
        public textline()
        {
            InitializeComponent();
        }

       

        private void button_click_Click(object sender, EventArgs e)
        {
            string text = tb_line.Text;
            //text_output.Text += text+"\r\n";
            if (tb_line.Text.Length != 0)
            {
                string next = "\r\n Thank You";
                text_output.AppendText((text + next) + "\r\n");
            }
            else 
            {
                MessageBox.Show("Must Write Something Here!","Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void button_enable_Click(object sender, EventArgs e)
        {
            button_click.Enabled = true;
            tb_line.Enabled = true;
           
        }

        private void button_disable_Click(object sender, EventArgs e)
        {
            button_click.Enabled = false;
            tb_line.Enabled = false;
            tb_line.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_line.Clear();
        }
    }
}
