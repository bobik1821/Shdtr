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
    public struct CrNewDialogRes
    {
        public int width;
        public int heidth;
        public bool ready;
    }
    public partial class F_MainForm : Form
    {
        F_Image imageField = null;
        public static bool ImageFieldOpened = false;

        public static IMageEditor imageEditor = new IMageEditor();
        public static CrNewDialogRes diagRes = new CrNewDialogRes();

        public F_MainForm()
        {
            InitializeComponent();

            p_Color.BackColor = Color.White;
            CreateField();
            openFileDialog1.Filter = "All files(*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            saveFileDialog1.Filter = "All files(*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void create_new_Click(object sender, EventArgs e)
        {
            F_CreateNewBitmap createNewBitmap = new F_CreateNewBitmap();
            createNewBitmap.ShowDialog();
            if (diagRes.ready)
            {
                imageEditor = new IMageEditor(diagRes.width, diagRes.heidth);
                imageField.Refresh();
                p_Color.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CreateField()
        {
            imageField = new F_Image();
            imageField.MdiParent = this;
            imageField.Show();
            ImageFieldOpened = true;
        }

        private void open_draw_window_Click(object sender, EventArgs e)
        {
            if(!ImageFieldOpened)
            {
                CreateField();
            }
        }

        private void close_open_window_Click(object sender, EventArgs e)
        {
            if(ImageFieldOpened)
            {
                imageField.Close();
                ImageFieldOpened = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //imageEditor.SetBrushRadius(Convert.ToInt32(nud_BrushRadius.Value));
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                imageEditor.LoadImage(filepath);
                imageField.Refresh();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filepath = saveFileDialog1.FileName;
                imageField.savePbImage(saveFileDialog1.FileName);
            }
        }

        private void p_Color_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                p_Color.BackColor = colorDialog1.Color;
                imageEditor.SetBrushColor(colorDialog1.Color);
            }
        }
    }
}

