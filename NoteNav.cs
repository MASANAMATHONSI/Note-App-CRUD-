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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string title = row.Cells["Title"].Value?.ToString() ?? "No Title";
                string content = row.Cells["Content"].Value?.ToString() ?? "";

                Notes detailForm = new Notes(title, content);
                detailForm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Notes addForm = new Notes();
            addForm.ShowDialog(); 
            dataGridView1.DataSource = new Datahandler().ViewAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.SearchNotes(textBox1.Text);
        }
    }
}
