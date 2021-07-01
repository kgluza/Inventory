using Inventory.Data.Dto;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Inventory.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly string connectionString;

        public CategoryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void AddCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("AddCategory", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = category.Name;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCategory(int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteCategory", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = categoryId;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Category> GetCategories(string id = null, string name = null)
        {
            List<Category> result = new List<Category>();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetCategories", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                    connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Category category = new Category
                            {
                                Id = dr.GetInt32(0),
                                Name = dr.GetString(1)
                            };

                            result.Add(category);
                        }
                    }

                    dr.Close();
                }

                connection.Close();
            }

            return result;
        }

        public Category GetCategoryById(int categoryId)
        {
            Category category = null;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetCategoryById", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = categoryId;
                    connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                     
                        category = new Category
                        {
                            Id = dr.GetInt32(0),
                            Name = dr.GetString(1)
                        };
                    }

                    dr.Close();
                }

                connection.Close();
            }

            return category;
        }

        public void UpdateCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateCategory", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = category.Id;
                    cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = category.Name;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
