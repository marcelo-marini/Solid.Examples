namespace Solid.Examples._2___OCP.Solucao {

    public abstract class DebitAccount {

        public string TransactionNumber { get; set; }
        public abstract string Debit(int amount, string account);
    }
}
