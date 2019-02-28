namespace Solid.Examples._2___OCP.Solucao {

    public class DebitCheckingAccount : DebitAccount {

        public override string Debit(int amount, string account) {

            // Lógica de débito em conta corrente

            return TransactionNumber;
        }
    }
}
