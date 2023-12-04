using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishNew
{
    public partial class pesnya : Form
    {
        public pesnya()
        {
            InitializeComponent();
            richTextBox1.LoadFile("Song.rtf");
        }
        SoundPlayer simpleSound = new SoundPlayer(@"D:\studiopril\EnglishNew\EnglishNew\bin\Debug\songsummer.wav");

        private void button1_Click(object sender, EventArgs e)
        {
            
            simpleSound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
        }

    }
}
