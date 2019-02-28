using System;
using System.Data.SqlClient;

namespace Solid.Examples._1___SRP.Violocao {

    public class Customer {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public void CreateCustomer() {

            if (string.IsNullOrWhiteSpace(this.Email)) {

                throw new Exception("Email is required.");
            }

            if (string.IsNullOrWhiteSpace(this.Name)) {

                throw new Exception("Name is required.");
            }

            using (var connection = new SqlConnection()) {

                var cmd = new SqlCommand();

                connection.ConnectionString = "SQL SERVER CONNECTION STRING";
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL) VALUES (@NAME, @EMAIL)";

                cmd.Parameters.AddWithValue("NAME", this.Name);
                cmd.Parameters.AddWithValue("EMAIL", this.Email);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
