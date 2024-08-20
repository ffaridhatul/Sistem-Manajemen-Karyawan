using Mission4.DAO;
using System;
using System.Windows.Forms;

namespace Mission4.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validasi input nomor karyawan dan password sebelum mencoba login
            if (!ValidateAll())
                return;

            // 2.1 Gunakan objek EmpDAO, jika nomor karyawan dan kata sandi yang dimasukkan valid (jika ada di tabel DB),
            // metode Hide() dipanggil sehingga jendela login tidak terlihat.
            var empDAO = EmpDAO.GetInstance();
            var emp = empDAO.Get(txtEmpNo.Text);

            // Cek apakah data karyawan ditemukan dan password yang dimasukkan cocok
            if (emp == null || emp.Password != txtPassword.Text)
            {
                // 2.2 Jika nomor karyawan atau kata sandi salah, kotak pesan ditampilkan
                MessageBox.Show("ID atau Password salah.", "Login gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Jika login berhasil, sembunyikan form login dan buka form utama
            this.Hide();

            // Pindah ke layar utama frmMain
            Form form = new frmMain();
            form.ShowDialog();

            // Setelah form utama ditutup, tutup juga form login
            this.Close();
        }

        private bool ValidateEmpNo()
        {
            // Validasi apakah nomor karyawan sudah diisi
            if (!string.IsNullOrEmpty(txtEmpNo.Text))
            {
                errEmpNo.Clear();
                return true;
            }
            else
            {
                errEmpNo.SetError(txtEmpNo, "Silakan masukkan nomor karyawan");
                return false;
            }
        }

        private bool ValidatePassword()
        {
            // Validasi apakah password sudah diisi
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                errPassword.Clear();
                return true;
            }
            else
            {
                errPassword.SetError(txtPassword, "Silakan masukkan password");
                return false;
            }
        }

        private bool ValidateAll()
        {
            bool validated = true;

            // Lakukan validasi untuk nomor karyawan dan password
            if (!ValidateEmpNo())
                validated = false;
            else if (!ValidatePassword())
                validated = false;

            return validated;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Tutup form login
            this.Close();
        }

        private void txtEmpNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Validasi saat nomor karyawan kehilangan fokus
            ValidateEmpNo();
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Validasi saat password kehilangan fokus
            ValidatePassword();
        }
    }
}
