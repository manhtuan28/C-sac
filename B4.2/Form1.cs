using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4._2
{
    public partial class frMangGoc : Form
    {
        private int[] array;
        public frMangGoc()
        {
            InitializeComponent();
        }

        private void lblImageLabel_Click(object sender, EventArgs e)
        {
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Resources", "qr-ng.jpg");

            if (System.IO.File.Exists(imagePath))
            {
                Form formImage = new Form();
                formImage.Text = "Donate";
                formImage.Size = new Size(500, 500);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = Image.FromFile(imagePath);

                formImage.Controls.Add(pictureBox);
                formImage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hình ảnh tại đường dẫn: " + imagePath);
            }
        }

        private void btnXuatNgauNhien_Click(object sender, EventArgs e)
        {
            txtMangGoc.Text = mangNgauNhien();
        }

        private void btnTongCacSoLe_Click(object sender, EventArgs e)
        {
            if (array != null)
            {
                txtKetQua.Text = tongSoLe(array).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng tạo mảng ngẫu nhiên trước!");
            }
        }

        private void btnDemCacSoLe_Click(object sender, EventArgs e)
        {
            if(array != null)
            {
                txtKetQua.Text = demSoLe(array).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng tạo mảng ngẫu nhiên trước!");
            }
        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {
            sapXepTang();
        }

        private void btnTimPhanTuNhoNhat_Click(object sender, EventArgs e)
        {
            timPhanTuNhoNhat();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string mangNgauNhien()
        {
            int n = 10;
            array = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-100, 101);
            }

            return string.Join(",", array);
        }

        private int tongSoLe(int[] array)
        {
            int ketQua = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    ketQua += array[i];
                }
            }
            return ketQua;
        }

        private int demSoLe(int[] array)
        {
            int dem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    dem++;
                }
            }
            return dem;
        }

        private void sapXepTang()
        {
            if(array != null)
            {
                Array.Sort(array);
                txtKetQua.Text = string.Join(",", array);
            }
            else
            {
                MessageBox.Show("Vui lòng tạo mảng ngẫu nhiên trước!");
            }
        }

        private void timPhanTuNhoNhat()
        {
            if(array != null && array.Length > 0)
            {
                int min = array.Min();
                txtKetQua.Text = min.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng tạo mảng ngẫu nhiên trước!");
            }
        }
    }
}
