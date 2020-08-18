using MicroRabbitMQ.MVC.Models.DTO;
using System.Threading.Tasks;

namespace MicroRabbitMQ.MVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDTO transferDTO);
    }
}
