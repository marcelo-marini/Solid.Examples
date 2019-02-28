namespace Solid.Examples._2___OCP.Solucao {
    public class DebitSavingsAccount : DebitAccount {

        public override string Debit(int amount, string account) {

            // Lógica de débito em conta poupança
            return TransactionNumber;
        }
    }
}
