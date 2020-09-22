using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dashboard.DataAccess.Abtract;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Dashboard.DataAccess.Concrete.Mysql
{
    public class MysqlCategoryDal : ICategoryDal
    {
        string _serverIp = "172.16.0.221";
        string _serverBackupDb = "Backup";
        MySqlConnection _conn;
        public List<Category> GetAll()
        {
            List<Category> Categories = new List<Category>();
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", _serverIp, _serverBackupDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = "select * from Categories where CategoryName <> 'server'";
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Category category = new Category
                                {
                                    CategoryId = reader.GetInt32(0),
                                    CategoryName = reader.GetString(1)
                                };
                                Categories.Add(category);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return Categories;
        }
        public int GetIdByName(string categoryName)
        {
            int categoryId = 0;
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", _serverIp, _serverBackupDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("select CategoryId from Categories where CategoryName ='{0}'", categoryName);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categoryId = reader.GetInt16(0);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("getIdByName sıkıntı var\n"+e);
            }
            return categoryId;
        }
    }
}
