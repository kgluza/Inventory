using Inventory.Data.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Inventory.Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly string connectionString;

        public ItemRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddItem(Item item)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("AddItem", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = item.Name;
                    cmd.Parameters.Add("@SerialNumber", SqlDbType.VarChar).Value = item.SerialNumber;
                    cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = item.CategoryId;
                    cmd.Parameters.Add("@LocationId", SqlDbType.Int).Value = item.LocationId;


                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteItem(int itemId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteItem", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = itemId;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Item> GetItems(string id = null, string name = null, string categoryName = null, string locationName = null, string serialNumber = null)
        {
            List<Item> result = new List<Item>();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetItems", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@SerialNumber", SqlDbType.VarChar).Value = serialNumber;
                    cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = categoryName;
                    cmd.Parameters.Add("@LocationName", SqlDbType.VarChar).Value = locationName;
                    connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Item item = new Item
                            {
                                Id = dr.GetInt32(0),
                                Name = dr.GetString(1),
                                CategoryId = dr.GetInt32(2),
                                CategoryName = dr.GetString(3),
                                LocationId = dr.GetInt32(4),
                                LocationName = dr.GetString(5),
                                SerialNumber = dr.GetString(6)
                            };

                            result.Add(item);
                        }
                    }

                    dr.Close();
                }

                connection.Close();
            }

            return result;
        }

        public Item GetItemById(int itemId)
        {
            Item item = null;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetItemById", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = itemId;
                    connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();

                        item = new Item
                        {
                            Id = dr.GetInt32(0),
                            Name = dr.GetString(1),
                            CategoryId = dr.GetInt32(2),
                            CategoryName = dr.GetString(3),
                            LocationId = dr.GetInt32(4),
                            LocationName = dr.GetString(5),
                            SerialNumber = dr.GetString(6)
                        };
                    }

                    dr.Close();
                }

                connection.Close();
            }

            return item;
        }

        public void UpdateItem(Item item)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateItem", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = item.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = item.Name;
                    cmd.Parameters.Add("@SerialNumber", SqlDbType.VarChar).Value = item.SerialNumber;
                    cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = item.CategoryId;
                    cmd.Parameters.Add("@LocationId", SqlDbType.Int).Value = item.LocationId;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UploadDocument(int itemId, string fileName)
        {
            FileInfo fi = new FileInfo(fileName);

            byte[] imageData = GetImageData(fileName);

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("AddDocument", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = itemId;
                    cmd.Parameters.Add("@File", SqlDbType.Image, imageData.Length).Value = imageData;
                    cmd.Parameters.Add("@FileName", SqlDbType.NVarChar).Value = fi.Name;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static byte[] GetImageData(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }

        List<Document> IItemRepository.GetDocuments(int itemId)
        {
            var documents = new List<Document>();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetDocuments", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = itemId;
                    connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            var document = new Document
                            {
                                Id = dr.GetInt32(0),
                                ItemId = dr.GetInt32(1),
                                Content = (byte[])dr[2],
                                FileName = dr.GetString(3)
                            };

                            documents.Add(document);
                        }
                    }

                    dr.Close();
                }

                connection.Close();
            }

            return documents;
        }
    }
}
