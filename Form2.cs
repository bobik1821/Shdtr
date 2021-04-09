using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaDeter
{

    public partial class F_CreateNewBitmap : Form
    {
        public F_CreateNewBitmap()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            F_MainForm.diagRes.ready = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void F_CreateNewBitmap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_MainForm.diagRes.width = Convert.ToInt32(numericUpDown2.Value);
            F_MainForm.diagRes.heidth = Convert.ToInt32(numericUpDown1.Value);
            F_MainForm.diagRes.ready = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
