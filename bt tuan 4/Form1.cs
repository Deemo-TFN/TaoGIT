using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_tuan_4
{
    public partial class frmCha : Form
    {
   
        public frmCha()
        {
            InitializeComponent();
        }
              private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Bitmap file | *.bmg| JPEG file| *.jpg";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                FormCon frm = new FormCon(oFile.FileName);
                frm.MdiParent = this;
                frm.Show(); 
            }
        }

       

     

     
    }
}
