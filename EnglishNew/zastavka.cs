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
    public partial class zastavka : Form
    {
        public zastavka()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {

                timer1.Stop();
                glavUroki form1 = new glavUroki();
                form1.Show();
                this.Hide();
            }
        }
    }
}
