using Mission4.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Mission4.DAO
{
    public class EmpDAO : IDAO<Emp>
    {
        private static EmpDAO empDAO;
        private EmpDAO() { }
        public static EmpDAO GetInstance()
        {
            if (empDAO == null)
            {
                empDAO = new EmpDAO();
            }
            return empDAO;
        }

        public Emp Get(string empNo)
        {
            Emp emp = null;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT e.Id EmpId, EmpNo, Name, Password, Title, DeptId, HireDate, ManagerId, Salary, Bonus, d.Id DeptId, d.DeptName, d.LocId ");
            sql.Append("FROM Emp e LEFT OUTER JOIN Dept d ON e.DeptId = d.Id ");
            sql.Append("WHERE EmpNo = @EmpNo");

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql.ToString(), con);
                cmd.Parameters.AddWithValue("@EmpNo", empNo);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    emp = new Emp
                    {
                        Id = Convert.ToInt32(reader["EmpId"]),
                        EmpNo = reader["EmpNo"].ToString(),
                        Name = reader["Name"].ToString(),
                        Password = reader["Password"].ToString(),
                        Title = reader["Title"].ToString(),
                        DeptId = reader["DeptId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["DeptId"]),
                        HireDate = Convert.ToDateTime(reader["HireDate"]),
                        ManagerId = reader["ManagerId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["ManagerId"]),
                        Salary = (int)Convert.ToDecimal(reader["Salary"]),  // Perbaikan 1
                        Bonus = reader["Bonus"] == DBNull.Value ? (int?)null : (int?)Convert.ToDecimal(reader["Bonus"]),  // Perbaikan 2
                        Dept = reader["DeptId"] == DBNull.Value ? null : new Dept
                        {
                            Id = Convert.ToInt32(reader["DeptId"]),
                            DeptName = reader["DeptName"].ToString(),
                            LocId = Convert.ToInt32(reader["LocId"])
                        }
                    };
                }

                reader.Close();
            }

            return emp;
        }

        public Emp Get(int id)
        {
            Emp emp = null;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT e.Id EmpId, EmpNo, Name, Password, Title, DeptId, HireDate, ManagerId, Salary, Bonus, d.Id DeptId, d.DeptName, d.LocId ");
            sql.Append("FROM Emp e LEFT OUTER JOIN Dept d ON e.DeptId = d.Id ");
            sql.Append("WHERE e.Id = @Id");

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql.ToString(), con);
                cmd.Parameters.AddWithValue("@Id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    emp = new Emp
                    {
                        Id = Convert.ToInt32(reader["EmpId"]),
                        EmpNo = reader["EmpNo"].ToString(),
                        Name = reader["Name"].ToString(),
                        Password = reader["Password"].ToString(),
                        Title = reader["Title"].ToString(),
                        DeptId = reader["DeptId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["DeptId"]),
                        HireDate = Convert.ToDateTime(reader["HireDate"]),
                        ManagerId = reader["ManagerId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["ManagerId"]),
                        Salary = (int)Convert.ToDecimal(reader["Salary"]),  // Perbaikan 3
                        Bonus = reader["Bonus"] == DBNull.Value ? (int?)null : (int?)Convert.ToDecimal(reader["Bonus"]),  // Perbaikan 4
                        Dept = reader["DeptId"] == DBNull.Value ? null : new Dept
                        {
                            Id = Convert.ToInt32(reader["DeptId"]),
                            DeptName = reader["DeptName"].ToString(),
                            LocId = Convert.ToInt32(reader["LocId"])
                        }
                    };
                }

                reader.Close();
            }

            return emp;
        }

        public List<Emp> GetAll()
        {
            List<Emp> empList = new List<Emp>();
            string sql = "SELECT e.Id EmpId, EmpNo, Name, Password, Title, DeptId, HireDate, ManagerId, Salary, Bonus, d.Id DeptId, d.DeptName, d.LocId " +
                         "FROM Emp e LEFT OUTER JOIN Dept d ON e.DeptId = d.Id";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var emp = new Emp
                    {
                        Id = Convert.ToInt32(reader["EmpId"]),
                        EmpNo = reader["EmpNo"].ToString(),
                        Name = reader["Name"].ToString(),
                        Password = reader["Password"].ToString(),
                        Title = reader["Title"].ToString(),
                        DeptId = reader["DeptId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["DeptId"]),
                        HireDate = Convert.ToDateTime(reader["HireDate"]),
                        ManagerId = reader["ManagerId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["ManagerId"]),
                        Salary = (int)Convert.ToDecimal(reader["Salary"]),  // Perbaikan 5
                        Bonus = reader["Bonus"] == DBNull.Value ? (int?)null : (int?)Convert.ToDecimal(reader["Bonus"]),  // Perbaikan 6
                        Dept = reader["DeptId"] == DBNull.Value ? null : new Dept
                        {
                            Id = Convert.ToInt32(reader["DeptId"]),
                            DeptName = reader["DeptName"].ToString(),
                            LocId = Convert.ToInt32(reader["LocId"])
                        }
                    };

                    empList.Add(emp);
                }

                reader.Close();
            }

            return empList;
        }

        public int Add(Emp emp)
        {
            int affectedRow = 0;
            string sql = "INSERT INTO Emp (EmpNo, Name, Password, Title, DeptId, HireDate, ManagerId, Salary, Bonus) " +
                         "VALUES (@EmpNo, @Name, @Password, @Title, @DeptId, @HireDate, @ManagerId, @Salary, @Bonus)";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Password", emp.Password);
                cmd.Parameters.AddWithValue("@Title", emp.Title);
                cmd.Parameters.AddWithValue("@DeptId", emp.DeptId.HasValue ? (object)emp.DeptId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                cmd.Parameters.AddWithValue("@ManagerId", emp.ManagerId.HasValue ? (object)emp.ManagerId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                cmd.Parameters.AddWithValue("@Bonus", emp.Bonus.HasValue ? (object)emp.Bonus.Value : DBNull.Value);

                affectedRow = cmd.ExecuteNonQuery();
            }

            return affectedRow;
        }

        public int Update(Emp emp)
        {
            int affectedRow = 0;
            string sql = "UPDATE Emp SET EmpNo = @EmpNo, Name = @Name, Password = @Password, Title = @Title, DeptId = @DeptId, " +
                         "HireDate = @HireDate, ManagerId = @ManagerId, Salary = @Salary, Bonus = @Bonus WHERE Id = @Id";

            using (var db = new DBHelper())
            {
                var con = db.Connection;
                con.Open();

                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Password", emp.Password);
                cmd.Parameters.AddWithValue("@Title", emp.Title);
                cmd.Parameters.AddWithValue("@DeptId", emp.DeptId.HasValue ? (object)emp.DeptId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                cmd.Parameters.AddWithValue("@ManagerId", emp.ManagerId.HasValue ? (object)emp.ManagerId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                cmd.Parameters.AddWithValue("@Bonus", emp.Bonus.HasValue ? (object)emp.Bonus.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Id", emp.Id);

                affectedRow = cmd.ExecuteNonQuery();
            }

            return affectedRow;
        }

        public int Delete(int id)
        {
            int affectedRow = 0;

            var sql1 = new StringBuilder();
            sql1.Append("DELETE FROM Certificate WHERE EmpId = @EmpId");

            var sql2 = new StringBuilder();
            sql2.Append("DELETE FROM Emp WHERE Id = @Id");

            try
            {
                using (var db = new DBHelper())
                {
                    db.Connection.Open();
                    var tx = db.Connection.BeginTransaction();

                    try
                    {
                        var cmd1 = new SqlCommand(sql1.ToString(), db.Connection, tx);
                        cmd1.Parameters.Add("@EmpId", SqlDbType.NVarChar).Value = id;
                        cmd1.ExecuteNonQuery();

                        var cmd2 = new SqlCommand(sql2.ToString(), db.Connection, tx);
                        cmd2.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                        affectedRow = cmd2.ExecuteNonQuery();

                        // Commit transaksi jika kedua operasi berhasil
                        tx.Commit();
                    }
                    catch (SqlException)
                    {
                        // Rollback transaksi jika ada kesalahan
                        tx.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "Error");
            }

            return affectedRow;
        }
    }
}
