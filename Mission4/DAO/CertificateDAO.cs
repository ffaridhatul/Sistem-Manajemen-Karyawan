using Mission4.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Mission4.DAO
{
    // 2. Terapkan pola Singleton untuk membatasi pembuatan objek yang tidak perlu.
    public class CertificateDAO : IDAO<Certificate>
    {
        // 2.1 Tambahkan konstruktor variabel private static CertificateDAO certificateDAO
        private static CertificateDAO certificateDAO;

        // 2.2 Konstruktor private
        private CertificateDAO() { }

        // 2.3 Tambahkan metode public static CertificateDAO GetInstance()
        public static CertificateDAO GetInstance()
        {
            if (certificateDAO == null)
            {
                certificateDAO = new CertificateDAO();
            }
            return certificateDAO;
        }

        // 3. Tuliskan metode public List<Certificate> GetAll(int empId)
        public List<Certificate> GetAll(int empId)
        {
            List<Certificate> certificateList = new List<Certificate>();
            string sql = "SELECT * FROM certificate WHERE EmpId = @EmpId";

            // Menggunakan DBHelper untuk koneksi database dan pengambilan data
            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@EmpId", empId);
                var reader = cmd.ExecuteReader();

                // Membaca data dari hasil query dan menambahkannya ke daftar Certificate
                while (reader.Read())
                {
                    var certificate = new Certificate
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CertificateName = reader["CertificateName"].ToString(),
                        EmpId = Convert.ToInt32(reader["EmpId"])
                    };

                    certificateList.Add(certificate);
                }

                reader.Close();
            }

            return certificateList;
        }

        // 4. Tuliskan metode public Certificate Get(int id)
        public Certificate Get(int id)
        {
            Certificate certificate = null;
            string sql = "SELECT * FROM certificate WHERE Id = @Id";

            // Menggunakan DBHelper untuk koneksi database dan pengambilan data
            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", id);
                var reader = cmd.ExecuteReader();

                // Jika data ditemukan, buat objek Certificate dan isi dengan data yang diambil
                if (reader.Read())
                {
                    certificate = new Certificate
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CertificateName = reader["CertificateName"].ToString(),
                        EmpId = Convert.ToInt32(reader["EmpId"])
                    };
                }

                reader.Close();
            }

            return certificate;
        }

        // 5. Tuliskan metode public int Add(Certificate certificate)
        public int Add(Certificate certificate)
        {
            int affectedRows = 0;
            string sql = "INSERT INTO certificate (CertificateName, EmpId) VALUES (@CertificateName, @EmpId)";

            // Menggunakan DBHelper untuk koneksi database dan eksekusi query
            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CertificateName", certificate.CertificateName);
                cmd.Parameters.AddWithValue("@EmpId", certificate.EmpId);

                // Menjalankan query dan mengembalikan jumlah baris yang terpengaruh
                affectedRows = cmd.ExecuteNonQuery();
            }

            return affectedRows;
        }

        // 6. Tuliskan metode public int Update(Certificate certificate)
        public int Update(Certificate certificate)
        {
            int affectedRows = 0;
            string sql = "UPDATE certificate SET CertificateName = @CertificateName, EmpId = @EmpId WHERE Id = @Id";

            // Menggunakan DBHelper untuk koneksi database dan eksekusi query
            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CertificateName", certificate.CertificateName);
                cmd.Parameters.AddWithValue("@EmpId", certificate.EmpId);
                cmd.Parameters.AddWithValue("@Id", certificate.Id);

                // Menjalankan query dan mengembalikan jumlah baris yang terpengaruh
                affectedRows = cmd.ExecuteNonQuery();
            }

            return affectedRows;
        }

        // 7. Tuliskan metode public int Delete(int id)
        public int Delete(int id)
        {
            int affectedRows = 0;
            string sql = "DELETE FROM certificate WHERE Id = @Id";

            // Menggunakan DBHelper untuk koneksi database dan eksekusi query
            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", id);

                // Menjalankan query dan mengembalikan jumlah baris yang terpengaruh
                affectedRows = cmd.ExecuteNonQuery();
            }

            return affectedRows;
        }

        // Metode yang tidak digunakan lagi
        public List<Certificate> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
