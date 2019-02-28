using System;

namespace Solid.Examples._5___DIP.Violacao {

    public class CustomerService {

        public void CreateCustomer(Customer customer) {

            if (customer.IsValid() == false) {

                throw new Exception("Invalid request");
            }

            var repository = new CustomerRepository();

            repository.CreateCustomer(customer);
        }
    }
}
