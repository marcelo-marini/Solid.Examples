namespace Solid.Examples._5___DIP.Violacao {

    public class Customer {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public bool IsValid() {

            if (string.IsNullOrWhiteSpace(this.Email)) {

                return false;
            }

            if (string.IsNullOrWhiteSpace(this.Name)) {

                return false;
            }

            return true;
        }
    }
}