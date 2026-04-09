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
    public partial class NoteNav : Form
    {
        Datahandler handler=new Datahandler();
        public NoteNav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.ViewAll();
        }
    }
}
