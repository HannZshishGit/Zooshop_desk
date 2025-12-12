using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace ZooShopDesktop.Models
{
    public enum LoginStatus
    {
        Ok,
        UserNotFound,
        WrongPassword,
        Error
    }

    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Role { get; set; }

        public static (LoginStatus Status, string FullName, string Role, string Error) LoginUser(string email, string password)
        {
            try
            {
                string query = $"select full_name, role_, hashed_password from Users where email_ = '{email}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader == null || !reader.HasRows)
                        return (LoginStatus.UserNotFound, null, null, "Користувача з таким email не знайдено");

                    reader.Read();
                    string storedPassword = reader["hashed_password"].ToString();

                    if (!BCrypt.Net.BCrypt.Verify(password, storedPassword))
                        return (LoginStatus.WrongPassword, null, null, "Невірний пароль");

                    return (LoginStatus.Ok, reader["full_name"].ToString(), reader["role_"].ToString(), null);
                }
            }
            catch (Exception ex)
            {
                return (LoginStatus.Error, null, null, ex.Message);
            }
        }

        public static string AddClient(string fullName, string phone, string email)
        {
            string query = $"INSERT INTO users (full_name, phone, email_, role_) VALUES ('{fullName}', '{phone}', '{email}', 'Клієнт')";

            try
            {
                DbConfig.ExecuteQuery(query);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string AddManager(string fullName, string phone, string email, string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string query = $"insert into Users (full_name, phone, email_, hashed_password, role_) values ('{fullName}', '{phone}', '{email}', '{hashedPassword}', 'Менеджер');";

            try
            {
                DbConfig.ExecuteQuery(query);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string DeleteManager(int id)
        {
            string query = $"delete from Users where user_id = {id}";

            try
            {
                DbConfig.ExecuteQuery(query);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string UpdateManager(string fullname, string phone, string email, int managerId)
        {
            string updateQuery = $"update users set full_name = '{fullname}', phone = '{phone}', email_ = '{email}' where user_id = '{managerId}';";

            try
            {
                DbConfig.ExecuteQuery(updateQuery);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static User LoadById(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            try
            {
                string query = $"select * from users where user_id = {id}";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.Read())
                    {
                        return new User
                        {
                            UserId = Convert.ToInt32(reader["user_id"]),
                            FullName = reader["full_name"].ToString(),
                            Email = reader["email_"].ToString(),
                            Phone = reader["phone"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public static User FindByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return null;

            try
            {
                string query = $"select user_id, full_name, phone, email_, role_ from users where email_ = '{email}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.Read())
                    {
                        return new User
                        {
                            UserId = Convert.ToInt32(reader["user_id"]),
                            FullName = reader["full_name"].ToString(),
                            Email = reader["email_"].ToString(),
                            Phone = reader["phone"].ToString(),
                            Role = reader["role_"].ToString()
                        };
                    }
                }
            }
            catch
            {

            }

            return null;
        }

        public static List<User> GetManagers()
        {
            var managers = new List<User>();

            try
            {
                string query = "select user_id, full_name, phone, email_, role_ from users where role_ = 'Менеджер';";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            managers.Add(new User
                            {
                                UserId = Convert.ToInt32(reader["user_id"]),
                                FullName = reader["full_name"].ToString(),
                                Email = reader["email_"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Role = reader["role_"].ToString()
                            });
                        }
                    }
                }
            }
            catch
            {

            }

            return managers;
        }
    }
}
