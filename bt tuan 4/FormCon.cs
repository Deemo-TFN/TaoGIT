using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_tuan_4
{
    public partial class FormCon : Form
    {


        public FormCon(string imageFile)
        {
            InitializeComponent();
         
            pictureBox1.Image = Image.FromFile(imageFile);

            Text = imageFile.Substring(imageFile.LastIndexOf('\\') + 1);

        }
        public FormCon()
        {
            InitializeComponent();
        }

        private void FormCon_Load(object sender, EventArgs e)
        {

        }
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
