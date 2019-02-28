using System;

namespace Solid.Examples._1___SRP.Solucao {

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
