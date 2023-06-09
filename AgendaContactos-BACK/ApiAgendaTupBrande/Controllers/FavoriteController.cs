using ApiAgendaTupBrande.Data.Repository.Implementation;
using ApiAgendaTupBrande.Data.Repository.Interfaces;
using ApiAgendaTupBrande.Entities;
using ApiAgendaTupBrande.Models.Dtos;
using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ApiAgendaTupBrande.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        //A traves de inyecion de dependencia podemos utilizar el contexto
        public FavoriteController(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        //[HttpPatch("{id}")]
        //public async Task<IActionResult> Patch(int id, JsonPatchDocument<Contact> favoriteDto)
        //{
        //    var contact = await _contactRepository.AddFavorite(id, JsonPatchDocument favoriteDTO);

        //}
//        try
//            {
//                // Hacemos el Mappeo
//                var contact = _mapper.Map<Contact>(favoriteDto);

//                if (id != contact.Id)
//                {
//                    return BadRequest();
//    }

//    var contactItem = await _contactRepository.GetContactById(contact.Id);

//                if (contactItem != null)
//                {
//                    return NotFound();
//}

//await _contactRepository.AddFavorite(contact);

//return Ok(new { message = "Favorito agregado" });

//            }
//            catch (Exception ex)
//{
//    return BadRequest(ex.Message);
//}
    }
}
