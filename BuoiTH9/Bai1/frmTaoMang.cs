using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmTaoMang : Form
    {
        private int soN;
        private int[] arr = new int[100];

        public int SoN { get => soN; set => soN = value; }       

        public frmTaoMang(int soN)
        {
            InitializeComponent();
            this.SoN = soN;       
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string taoMang()
        {           
            Random random = new Random(); 
            string mang = "";
            for (int i = 0; i < SoN; i++)
            {
                this.arr[i] = random.Next(SoN, SoN + 12);
                mang += this.arr[i] + " ";
            }
            return mang;
        }

        public string mangSoChan()
        {
            string mang = "";
            for (int i = 0; i < SoN; i++)
                if (this.arr[i] % 2 == 0)
                    mang += this.arr[i] + " ";
            return mang;
        }
        private void frmTaoMang_Load(object sender, EventArgs e)
        {
            this.txtMang.Text = this.taoMang();
            this.txtMangSoChan.Text = this.mangSoChan();
        }
    }
}
