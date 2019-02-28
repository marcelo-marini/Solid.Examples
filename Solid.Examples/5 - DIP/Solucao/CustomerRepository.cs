using System.Data.SqlClient;

namespace Solid.Examples._5___DIP.Solucao {

    public class CustomerRepository : ICustomerRepository {

        public void CreateCustomer(Customer customer) {

            using (var connection = new SqlConnection()) {

                var cmd = new SqlCommand();

                connection.ConnectionString = "SQL SERVER CONNECTION STRING";
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL) VALUES (@NAME, @EMAIL)";

                cmd.Parameters.AddWithValue("NAME", customer.Name);
                cmd.Parameters.AddWithValue("EMAIL", customer.Email);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
