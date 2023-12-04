
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishNew
{
    public partial class glavUroki : Form
    {
        public glavUroki()
        {
            InitializeComponent();
        }

        private void movepanel(Control btn)
        {
            panelslide.Width = btn.Width;
            panelslide.Left = btn.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movepanel(uroki);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movepanel(pesnya);
            pesnya form = new pesnya();
            form.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movepanel(alfavit);
            alfavit form = new alfavit();
            form.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movepanel(info);
            info form = new info();
            form.ShowDialog(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                richTextBox1.LoadFile("Urok1.rtf");
            }
            if (listBox1.SelectedIndex == 1)
            {
                richTextBox1.LoadFile("Urok2.rtf");
            }
            if (listBox1.SelectedIndex == 2)
            {
                richTextBox1.LoadFile("Urok3.rtf");
            }
            if (listBox1.SelectedIndex == 3)
            {
                richTextBox1.LoadFile("Urok4.rtf");
            }
            if (listBox1.SelectedIndex == 4)
            {
                richTextBox1.LoadFile("Urok5.rtf");
            }
        }

        private void glavUroki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
