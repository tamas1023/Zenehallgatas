using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenehallgatas.Model;

namespace Zenehallgatas.DAO
{
    internal class ZeneDaoImpl : IZeneDao
    {
        private static readonly string s_connection_string = @"Data Source=DB\zene.db";
        public bool addZene(Zene zene)
        {
            //Az egyéb hibákat frontenden kell lekezelni

            using (SQLiteConnection conn = new SQLiteConnection(s_connection_string))
            {
                conn.Open();

                using(SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from Zenek WHERE Title LIKE  @Title ";

                    cmd.Parameters.Add("Title", System.Data.DbType.String).Value = "%"+ zene.Title+"%";

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            return false;
                        }

                    };
                }
                
                using(SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Zenek " +
                                       "(Title,Performer,ReleaseDate,Length,Priority) " +
                                       "Values " +
                                       "(@Title,@Performer,@ReleaseDate,@Length,@Priority)";
                    cmd.Parameters.Add("Title", System.Data.DbType.String).Value = zene.Title;
                    cmd.Parameters.Add("Performer", System.Data.DbType.String).Value = zene.Performer;
                    cmd.Parameters.Add("ReleaseDate", System.Data.DbType.Int32).Value = zene.ReleaseDate;
                    cmd.Parameters.Add("Length", System.Data.DbType.Int32).Value = zene.Length;
                    cmd.Parameters.Add("Priority", System.Data.DbType.Int32).Value = zene.Priority;


                    int row = cmd.ExecuteNonQuery();

                    if (row != 1)
                    {
                        return false;
                    }
                    
                }


                conn.Close();
            }


            return true;
        }

        public List<Zene> getAllZeneList()
        {
            List<Zene> test =  new List<Zene> { new Zene(0, "Cím", "Valki", 2024, 1,1),
                                    new Zene(1,"Immigrant song","Led Zeppelin",2020,226,2),
                                    new Zene(2,"BACK2BACK","STRLGHT",2023,223,3),
                                    new Zene(3,"I Had Some Help","Post Malone",2024,321,5)};

            List<Zene> allZene = new List<Zene>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(s_connection_string))
                {
                    conn.Open();

                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * from Zenek";

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {

                            allZene = ReadZenekFromReader(reader);
                        };
                    };


                    conn.Close();
                };

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Zene>();
            }
            

            return allZene;
        }

        private List<Zene> ReadZenekFromReader(SQLiteDataReader reader)
        {
            List<Zene> allZene = new List<Zene>();
            while (reader.Read())
            {

                
                int Id = reader.GetInt32(reader.GetOrdinal("ID"));
                string Title = reader.GetString(reader.GetOrdinal("Title"));
                string Performer = reader.GetString(reader.GetOrdinal("Performer"));
                int ReleaseDate = reader.GetInt32(reader.GetOrdinal("ReleaseDate"));
                int Length = reader.GetInt32(reader.GetOrdinal("Length"));
                int Priority = reader.GetInt32(reader.GetOrdinal("Priority"));


                Zene tempZene = new Zene(Id,Title,Performer,ReleaseDate,Length,Priority);
                allZene.Add(tempZene);
            }

            allZene = allZene.OrderByDescending(s => s.Priority).ToList();
            return allZene;
        }

        public Zene getZene(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(s_connection_string))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from Zenek WHERE ID = @ID";

                    cmd.Parameters.Add("ID", System.Data.DbType.String).Value = id;

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            int Id = reader.GetInt32(reader.GetOrdinal("ID"));
                            string Title = reader.GetString(reader.GetOrdinal("Title"));
                            string Performer = reader.GetString(reader.GetOrdinal("Performer"));
                            int ReleaseDate = reader.GetInt32(reader.GetOrdinal("ReleaseDate"));
                            int Length = reader.GetInt32(reader.GetOrdinal("Length"));
                            int Priority = reader.GetInt32(reader.GetOrdinal("Priority"));


                            return new Zene(Id, Title, Performer, ReleaseDate, Length, Priority);
                        }
                        return new Zene(-1, "Baj van", "Nagyon", 2024, 10, 3);

                    };
                };
            };
        }

        public bool modifyZene(Zene zene)
        {

            using (SQLiteConnection conn = new SQLiteConnection(s_connection_string))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Zenek SET Priority = @Priority WHERE ID = @ID ";

                    cmd.Parameters.Add("Priority", System.Data.DbType.String).Value =  zene.Priority;
                    cmd.Parameters.Add("ID", System.Data.DbType.Int32).Value = zene.Id;

                    int row = cmd.ExecuteNonQuery();

                    if (row != 1)
                    {
                        return false;
                    }
                }


                conn.Close();
            }


            return true;
        }
    }
}
