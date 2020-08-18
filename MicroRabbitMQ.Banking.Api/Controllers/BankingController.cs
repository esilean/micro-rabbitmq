using MicroRabbitMQ.Banking.Application.Interfaces;
using MicroRabbitMQ.Banking.Application.Models;
using MicroRabbitMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MicroRabbitMQ.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        /// <summary>
        /// Returns all accounts
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        /// <summary>
        /// Creates a Account Transfer.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/account
        ///     {
        ///        "FromAccount": 1,
        ///        "ToAccount": 2,
        ///        "TransferAmount": 10
        ///     }
        ///
        /// </remarks>
        /// <param name="accountTransfer"></param>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="200">Returns the newly created item</response>
        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);

            return Ok(accountTransfer);
        }
    }
}
