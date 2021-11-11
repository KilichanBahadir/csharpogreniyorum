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
        public class ContactsController : ControllerBase
        {
            private readonly IContactService _contactService;
            private readonly IMapper _mapper;

            public ContactsController(IContactService contactService, IMapper mapper)
            {
                _contactService = contactService;
                _mapper = mapper;
            }

            [HttpGet(Name = "GetContactsAsync")]
            public async Task<ActionResult<List<ContactDto>>> GetContactsAsync()
            {
                var contacts = await _contactService.GetAllAsync();
                if (contacts == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<IList<ContactDto>>(contacts));

            }

            // GET api/values/5
            [HttpGet("{id}", Name = "GetContactByIdAsync")]
            public async Task<ActionResult<ContactDto>> GetContactByIdAsync(int id)
            {
                var contact = await _contactService.GetByIdAsync(id)
    ;
                if (contact == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<ContactDto>(contact));
            }
            // POST api/values
            [HttpPost(Name = "AddContactAsync")]
            public async Task<ActionResult<ContactDto>> AddContactAsync(ContactDto contactDto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var contact = _mapper.Map<Contact>(contactDto);

                await _contactService.AddAsync(contact);
                return CreatedAtRoute("GetContactByIdAsync", new { id = contact.Id }, _mapper.Map<ContactDto>(contact));
            }

            // PUT api/values/5
            [HttpPut("{id}", Name = "UpdateContactAsync")]
            public async Task<ActionResult<ContactDto>> UpdateContactAsync(int id, [FromBody] ContactDto contactDto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                if (id != contactDto.Id)
                {
                    return BadRequest();
                }
                var contactToBeUpdate = await _contactService.GetByIdAsync(id)
    ;
                if (contactToBeUpdate == null)
                {
                    return NotFound();
                }

                var contact = _mapper.Map<Contact>(contactDto);
                await _contactService.UpdateAsync(contact);
                return NoContent();

            }

            // DELETE api/values/5
            [HttpDelete("{id}", Name = "RemoveContactAsync")]
            public async Task<ActionResult> RemoveContactAsync(int id)
            {
                var contactToBeDelete = await _contactService.GetByIdAsync(id)
    ;

                if (contactToBeDelete == null)
                {
                    return NotFound();
                }
                await _contactService.DeleteAsync(id)
    ;

                return NoContent();
            }
        }
    }

