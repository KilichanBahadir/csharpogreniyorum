using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Bal.Abstract;
using Works34.Dtos;
using Works34.Entities;

namespace Works34.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountsController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAccountsAsync")]
        public async Task<ActionResult<List<AccountDto>>> GetAccountsAsync()
        {
            var accounts = await _accountService.GetAllAsync();
            if (accounts == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IList<AccountDto>>(accounts));

        }

        // GET api/values/5
        [HttpGet("{id}", Name = "GetAccountByIdAsync")]
        public async Task<ActionResult<AccountDto>> GetAccountByIdAsync(int id)
        {
            var account = await _accountService.GetByIdAsync(id)
;
            if (account == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AccountDto>(account));
        }
        // POST api/values
        [HttpPost(Name = "AddAccountAsync")]
        public async Task<ActionResult<AccountDto>> AddAccountAsync(AccountDto accountDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var account = _mapper.Map<Account>(accountDto);

            await _accountService.AddAsync(account);
            return CreatedAtRoute("GetAccountByIdAsync", new { id = account.Id }, _mapper.Map<AccountDto>(account));
        }

        // PUT api/values/5
        [HttpPut("{id}", Name = "UpdateAccountAsync")]
        public async Task<ActionResult<AccountDto>> UpdateAccountAsync(int id, [FromBody] AccountDto accountDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (id != accountDto.Id)
            {
                return BadRequest();
            }
            var accountToBeUpdate = await _accountService.GetByIdAsync(id)
;
            if (accountToBeUpdate == null)
            {
                return NotFound();
            }

            var account = _mapper.Map<Account>(accountDto);
            await _accountService.UpdateAsync(account);
            return NoContent();

        }

        // DELETE api/values/5
        [HttpDelete("{id}", Name = "RemoveAccountAsync")]
        public async Task<ActionResult> RemoveAccountAsync(int id)
        {
            var accountToBeDelete = await _accountService.GetByIdAsync(id)
;

            if (accountToBeDelete == null)
            {
                return NotFound();
            }
            await _accountService.DeleteAsync(id)
;

            return NoContent();
        }
    }
}
