namespace Solid.Examples._2___OCP.Violacao   {

    public class DebitAccount {

        public void Debit(int amount, string conta, AccountType type) {

            if (type == AccountType.Checking) {

                // Lógica de débito em conta corrente
            }
            else if (type == AccountType.Savings) {

                // Lógica de débito em conta poupança
            }
        }
    }
}
