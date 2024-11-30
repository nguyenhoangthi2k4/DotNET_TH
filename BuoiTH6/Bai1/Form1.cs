using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)  
                this.txtHienThi.Font = fontDialog.Font;
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
                this.txtHienThi.ForeColor = colorDialog.Color;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file (*.txt) | .txt";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                this.txtHienThi.Text = File.ReadAllText(filename);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt) | .txt";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                Stream stream = saveFileDialog.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(this.txtHienThi.Text);
                writer.Close();
                stream.Close();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn muốn thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                e.Cancel = false;
            else 
                e.Cancel = true;
        }
    }
}
