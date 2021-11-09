using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateKeyPair
{
    public partial class mainForm : Form
    {
        private bool isSave = false;
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            isSave = false;
            int choice = cbbKeySize.SelectedIndex;
            int keySize = 2048;
            switch (choice)
            {
                case 0:
                    keySize = 512;
                    break;
                case 1:
                    keySize = 1024;
                    break;
                case 2:
                    keySize = 2048;
                    break;
                default:
                    break;
            }
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keySize);
            rsa.ExportParameters(true);
            txtPrivateKey.Text = RSAService.ExportPrivateKey(rsa);
            txtPublicKey.Text = RSAService.ExportPublicKey(rsa);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtPrivateKey.Text != string.Empty)
            {
                if (!isSave)
                {
                    DialogResult ques = MessageBox.Show("Bạn chưa lưu key? Có muốn thoát mà không lưu không?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ques == DialogResult.Yes)
                    {
                        Environment.Exit(0);
                    }
                    return;
                }
            }
            Environment.Exit(0);
        }

        private void btnSavePrivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrivateKey.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng tạo cặp key trước rồi mới lưu!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = ".pem|*.pem";

                if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName != string.Empty)
                {
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(txtPrivateKey.Text);
                        sw.Close();
                    }
                    isSave = true;
                    MessageBox.Show("Đã lưu file private key ở đường dẫn " + saveFile.FileName, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu file, thử lại hoặc liên hệ mình bằng cách nhấn nút liên hệ!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void btnSavePublic_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPublicKey.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng tạo cặp key trước rồi mới lưu!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = ".pem|*.pem";

                if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName != string.Empty)
                {
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(txtPublicKey.Text);
                        sw.Close();
                    }
                    isSave = true;
                    MessageBox.Show("Đã lưu file public key ở đường dẫn " + saveFile.FileName, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu file, thử lại hoặc liên hệ mình bằng cách nhấn nút liên hệ!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/ledunguit");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bước 1: Chọn độ lớn của key, có các lựa chọn 512 bit, 1024 bit và 2048 bit, số bit càng cao càng có độ bảo mật cao hơn, số bit càng thấp thì giải mã và mã hóa nhanh hơn!\nBước 2: Nhấn vào tạo cặp key.\nBước 3: Tiến hành lưu key thành file.pem và sử dụng!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
