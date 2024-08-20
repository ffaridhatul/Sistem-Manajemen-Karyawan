using Mission4.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Mission4.DAO
{
    // 2. Terapkan pola Singleton untuk membatasi pembuatan objek yang tidak perlu.
    public class DeptDAO : IDAO<Dept>
    {
        // 2.1 Tambahkan konstruktor private, private static DeptDAO deptDAO
        private static DeptDAO deptDAO;

        // 2.2 Konstruktor private
        private DeptDAO() { }

        // 2.3 Tambahkan metode public static DeptDAO GetInstance()
        public static DeptDAO GetInstance()
        {
            if (deptDAO == null)
            {
                deptDAO = new DeptDAO();
            }
            return deptDAO;
        }

        // 3. Tulis metode public List<Dept> GetAll()
        public List<Dept> GetAll()
        {
            List<Dept> depts = new List<Dept>();
            string sql = "SELECT * FROM dept";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var dept = new Dept
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DeptName = reader["DeptName"].ToString(),
                        LocId = Convert.ToInt32(reader["LocId"])
                    };

                    depts.Add(dept);
                }

                reader.Close();
            }

            return depts;
        }

        // 4. Tulis metode public Dept Get(int id)
        public Dept Get(int id)
        {
            Dept dept = null;
            string sql = "SELECT * FROM dept WHERE Id = @Id";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dept = new Dept
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DeptName = reader["DeptName"].ToString(),
                        LocId = Convert.ToInt32(reader["LocId"])
                    };
                }

                reader.Close();
            }

            return dept;
        }

        // 5. Tulis metode public int Add(Dept dept)
        public int Add(Dept dept)
        {
            int affectedRows = 0;
            string sql = "INSERT INTO dept (DeptName, LocId) VALUES (@DeptName, @LocId)";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@DeptName", dept.DeptName);
                cmd.Parameters.AddWithValue("@LocId", dept.LocId);

                affectedRows = cmd.ExecuteNonQuery();
            }

            return affectedRows;
        }

        // 6. Tulis metode public int Update(Dept dept)
        public int Update(Dept dept)
        {
            int affectedRows = 0;
            string sql = "UPDATE dept SET DeptName = @DeptName, LocId = @LocId WHERE Id = @Id";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@DeptName", dept.DeptName);
                cmd.Parameters.AddWithValue("@LocId", dept.LocId);
                cmd.Parameters.AddWithValue("@Id", dept.Id);

                affectedRows = cmd.ExecuteNonQuery();
            }

            return affectedRows;
        }

        // 7. Tulis metode public int Delete(int id)
        public int Delete(int id)
        {
            int affectedRows = 0;
            string sql = "DELETE FROM dept WHERE Id = @Id";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", id);

                affectedRows = cmd.ExecuteNonQuery();
            }

            return affectedRows;
        }
    }
}
