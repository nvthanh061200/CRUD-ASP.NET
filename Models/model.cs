using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lap2.Models
{
    public class model
    {
        SqlConnection connection;
        public void open(){
            connection = new SqlConnection("Data Source=DESKTOP-51BR119\\SQLEXPRESS;Initial Catalog=Lap1;Integrated Security=True");
            connection.Open();
        }
        public List<people> Show(){
            List<people> list = new List<people>();
            open();
            SqlCommand command = new SqlCommand("Select * from Lap1", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                list.Add(new people(
                    int.Parse(reader["ID"].ToString()),
                    reader["HoTen"].ToString(),
                    reader["NgaySinh"].ToString()
                    ));
            }
            return list;
        }
        public bool Delete(string ID) {
            open();
            SqlCommand command = new SqlCommand("DELETE FROM Lap1 WHERE ID=@0", connection);
            command.Parameters.Add(new SqlParameter("@0", ID));
            command.ExecuteNonQuery();
            return true;
        }
        public bool Create(people p){
            open();
            SqlCommand command = new SqlCommand("INSERT INTO Lap1 (HoTen,NgaySinh) VALUES (@0,@1)", connection);
            command.Parameters.Add(new SqlParameter("@0", p.HoTen));
            command.Parameters.Add(new SqlParameter("@1", p.NgaySinh));
            command.ExecuteNonQuery();
            return true;
        }
        public bool Edit(people p){
            open();
            SqlCommand command = new SqlCommand("UPDATE Lap1 SET HoTen=@0,NgaySinh=@1 WHERE ID=@2", connection);
            command.Parameters.Add(new SqlParameter("@0", p.HoTen));
            command.Parameters.Add(new SqlParameter("@1", p.NgaySinh));
            command.Parameters.Add(new SqlParameter("@2", p.ID));
            command.ExecuteNonQuery();
            return true;
        }
    }
}