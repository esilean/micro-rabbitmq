using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroRabbitMQ.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; private set; }

        [Required]
        [StringLength(50)]
        public string AccountType { get; private set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal AccountBalance { get; private set; }

        public Account(string accountType, decimal accountBalance)
        {
            AccountType = accountType;
            AccountBalance = accountBalance;
        }
    }
}
