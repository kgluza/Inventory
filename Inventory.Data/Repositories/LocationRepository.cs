using Inventory.Data.Dto;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Inventory.Data.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly string connectionString;

        public LocationRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddLocation(Location location)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("AddLocation", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Location", SqlDbType.VarChar).Value = location.Name;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteLocation(int locationId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteLocation", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = locationId;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Location> GetLocations(string id = null, string name = null)
        {
            List<Location> result = new List<Location>();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetLocations", connection))
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
                            Location location = new Location
                            {
                                Id = dr.GetInt32(0),
                                Name = dr.GetString(1)
                            };

                            result.Add(location);
                        }
                    }

                    dr.Close();
                }

                connection.Close();
            }

            return result;
        }

        public Location GetLocationById(int locationId)
        {
            Location location = null;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetLocationById", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = locationId;
                    connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();

                        location = new Location
                        {
                            Id = dr.GetInt32(0),
                            Name = dr.GetString(1)
                        };
                    }

                    dr.Close();
                }

                connection.Close();
            }

            return location;
        }

        public void UpdateLocation(Location location)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateLocation", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = location.Id;
                    cmd.Parameters.Add("@location", SqlDbType.VarChar).Value = location.Name;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
