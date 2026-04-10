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
        private int currentNoteId = 0;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Datahandler handler = new Datahandler();

            if (currentNoteId == 0)
            {
                handler.AddNote(textBox1.Text, textBox2.Text);
                MessageBox.Show("New Note Created!");
            }
            else
            {
                handler.EditNote(currentNoteId, textBox1.Text, textBox2.Text);
                MessageBox.Show("Note Updated!");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (currentNoteId > 0)
            {
               
                DialogResult confirm = MessageBox.Show("Delete this note permanently?", "Confirm", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    Datahandler handler = new Datahandler();
                    handler.DeleteNote(currentNoteId);
                    this.Close();
                }
            }
            else
            {
               
                this.Close();
            }
        }
        }
}
