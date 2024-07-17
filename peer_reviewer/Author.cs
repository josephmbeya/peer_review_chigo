using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peer_Reviewer
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        void LoadFile()
        {
            DialogResult DR = openFileDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
               /* File = Image.FromFile(openFileDialog1.FileName);
                picb.Image = File;
                opened = true;*/

            }
        }

        private void btnempupdate_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
    }
}
