using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAPIToDB.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }
        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
                return list;
            }
        }
        public List<EmployeeItem> GetEmployee(int id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }

            return list;
        }

        public String AddEmployee(EmployeeItem employee)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand($"INSERT INTO employee VALUES (NULL, @nama, @jenisKelamin, @alamat)", conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", employee.nama);
                        cmd.Parameters.AddWithValue("@jenisKelamin", employee.jenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", employee.alamat);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    };
                    return "success";
                }
            }
            catch (Exception err)
            {
                return $"Error : {err.Message}";
                throw;
            }
        }
        public String EditEmployeeName(int id, String nama)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand($"UPDATE employee SET nama='@nama' WHERE id='@id'"))
                    {

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nama", nama);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                return "Success";
            }
            catch (Exception err)
            {
                return $"Error : {err.Message}";
            }
        }
    }
}
