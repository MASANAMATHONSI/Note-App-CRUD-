using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_App__CRUD_
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }
        public Notes(string title, string content)
        {
            InitializeComponent();
            textBox1.Text = title;
            textBox2.Text = content;
        }

        private void Notes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
