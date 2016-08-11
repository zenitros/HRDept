using System;
using System.Configuration;
using System.Data.SqlClient;
using HRDept.Data.Contracts;
using HRDept.Model.Entity;

namespace HRDept.Data.Impl
{
    public class MsSqlRepo: IRepo
    {
        private string _connString;

        public MsSqlRepo()
        {
            _connString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public void AddEmployee(Employee data)
        {
            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.CommandText = SqlQueries.AddEmployee;

                    cmd.Parameters.AddWithValue("@Name", data.Name);
                    cmd.Parameters.AddWithValue("@Position", data.Position);
                    cmd.Parameters.AddWithValue("@DateOfBirth", data.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Department", data.Department);
                    cmd.Parameters.AddWithValue("@IsFired", data.IsFired);
                    cmd.Parameters.AddWithValue("@Id", data.EntityBaseId); 

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddDepartment(Department data)
        {
            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConn;
                    cmd.Parameters.AddWithValue("@Name", data.Name);
                    cmd.Parameters.AddWithValue("@Id", data.EntityBaseId);
                    cmd.Parameters.AddWithValue("@Lead_id", Guid.NewGuid());

                    if (data.ParentId != null)
                    {
                        cmd.CommandText = SqlQueries.AddDepartment;
                        cmd.Parameters.AddWithValue("@ParentId", data.ParentId);
                    }
                    else
                    {
                        cmd.CommandText = SqlQueries.AddBaseDepartment;
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddVacancy(Vacancy data)
        {
            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.CommandText = SqlQueries.AddVacancy;

                    cmd.Parameters.AddWithValue("@DepartmentGuid", data.DepartmentGuid);
                    cmd.Parameters.AddWithValue("@Description", data.Description);
                    cmd.Parameters.AddWithValue("@Position", data.Position);
                    cmd.Parameters.AddWithValue("@Id", data.EntityBaseId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployee(Employee data)
        {
            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();
                using (var cmd = new SqlCommand())
                {
                    if (data.IsFired == false)
                    {
                        cmd.Parameters.AddWithValue("@Department", data.Department);
                        cmd.Parameters.AddWithValue("@Id", data.EntityBaseId);
                        cmd.CommandText = SqlQueries.UpdateEmployee;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@IsFired", data.IsFired);
                        cmd.CommandText = SqlQueries.FireEmployee;
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Employee GetEmployee(string name)
        {
            Employee result = null;
            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.CommandText = SqlQueries.GetEmployee;

                    cmd.Parameters.AddWithValue("@Name", name);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        result = new Employee
                        {
                            Name = name,
                            DateOfBirth = reader.GetDateTime(0),
                            Department = reader.GetGuid(1),
                            IsFired = reader.GetBoolean(2),
                            Position = reader.GetString(3)
                        };
                    }
                }
            }
            return result;
        }

        public Vacancy GetVacancy()
        {
            Vacancy vacancy = null;
            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.CommandText = SqlQueries.GetVacancy;


                }
            }
            return vacancy;
        }
    }
}
