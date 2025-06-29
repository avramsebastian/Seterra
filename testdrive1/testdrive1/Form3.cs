using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testdrive1
{
    public partial class Meniu_Dificultăți : Form
    {
        int timpselectat;

        public Meniu_Dificultăți()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timpselectat = 360;
            Joc f = new Joc(timpselectat);
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timpselectat = 240;
            Joc f = new Joc(timpselectat);
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timpselectat = 10;
            Joc f = new Joc(timpselectat);
            f.ShowDialog();
            this.Close();
        }
    }
}