using System.ComponentModel.DataAnnotations;

namespace MicroRabbitMQ.Banking.Application.Models
{
    public class AccountTransfer
    {
        [Required]
        public int FromAccount { get; set; }

        [Required]
        public int ToAccount { get; set; }

        [Required]
        public decimal TransferAmount { get; set; }

    }
}
