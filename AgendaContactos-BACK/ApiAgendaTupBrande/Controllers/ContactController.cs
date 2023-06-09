using ApiAgendaTupBrande.Data;
using ApiAgendaTupBrande.Data.Repository.Interfaces;
using ApiAgendaTupBrande.Entities;
using ApiAgendaTupBrande.Models.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAgendaTupBrande.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ContactController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        //A traves de inyecion de dependencia podemos utilizar el contexto
        public ContactController(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listContacts = await _contactRepository.GetListContacts();

                var listContactsDto = _mapper.Map<IEnumerable<ContactDTO>>(listContacts);

                return Ok(listContacts);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var contact = await _contactRepository.GetContactById(id);

                if (contact == null)
                {
                    return NotFound();
                }

                // Aplicamos AutoMapper para devolver DTO y no entidad
                var contactDto = _mapper.Map<ContactDTO>(contact);

                return Ok(contactDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var contact = await _contactRepository.GetContactById(id);

                if (contact == null)
                {
                    return NotFound();
                }

                await _contactRepository.DeleteContact(contact);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ContactDTO contactDto)
        {
            try
            {
                var contact = _mapper.Map<Contact>(contactDto);

                contact = await _contactRepository.AddContact(contact);

                var contactItemDto = _mapper.Map<ContactDTO>(contact);

                return Ok(contactItemDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ContactDTO contactDto)
        {
            try
            {
                // Hacemos el Mappeo
                var contact = _mapper.Map<Contact>(contactDto);

                if (id != contact.Id)
                {
                    return BadRequest();
                }

                await _contactRepository.UpdateContact(contact);

                return Ok(new { message = "Contacto actualizado con exito!" });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    } 
}
