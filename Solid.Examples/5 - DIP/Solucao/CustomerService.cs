using System;

namespace Solid.Examples._5___DIP.Solucao {

    public class CustomerService {

        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository) {

            _repository = repository;
        }

        public void CreateCustomer(Customer customer) {

            if (customer.IsValid() == false) {

                throw new Exception("Invalid request");
            }

            _repository.CreateCustomer(customer);
        }
    }
}
