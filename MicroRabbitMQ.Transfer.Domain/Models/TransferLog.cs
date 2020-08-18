using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroRabbitMQ.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; private set; }

        [Required]
        public int FromAccount { get; private set; }

        [Required]
        public int ToAccount { get; private set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TransferAmount { get; private set; }

        public TransferLog(int fromAccount, int toAccount, decimal transferAmount)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            TransferAmount = transferAmount;
        }
    }
}
