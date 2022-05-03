using AlAhlyMomkn.DAL.Models;
using AlAhlyMomkn.DTO.ViewModel;
using AlAhlyMomkn.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlAhlyMomkn_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItem _item;
        public ItemController(IItem item)
        {
            _item = item;
        }

        [HttpGet("GetItemById")]
        public ActionResult<ItemDto> GetItemById(int Id)
        {
            var item = _item.GetById(Id);

            if (item == null)
            {
                return NotFound("Record not found");
            }

            return Ok(item);
        }

        [HttpPost("UpdateItem")]
        public IActionResult UpdateItem([FromBody] ItemDto itemDto)
        {
            var item = _item.GetById(itemDto.Id);
            try
            {
                item.Id= itemDto.Id;
                item.Title= itemDto.Title;
                item.Description= itemDto.Description;
                item.StepId= itemDto.stepId;
                _item.Update(item);
            }
            catch (Exception ex)
            {
                return NotFound("Record not found");
            }

            return Ok(item);
        }

        [HttpPost("AddItem")]
        public ActionResult AddItem([FromBody] ItemDto itemDto)
        {
            var item = Item.Clone(itemDto);
            try
            {
                _item.Add(item);
            }
            catch (Exception ex)
            {
                return NotFound("Record not found");
            }

            return Ok(itemDto);
        }

        [HttpGet("DeleteItem")]
        public ActionResult DeleteItem(int Id)
        {
            var Item = _item.GetById(Id);
            if (Item == null)
            {
                return NotFound("Record not found");
            }

            _item.Delete(Item);
            return Ok(Item);
        }
    }
}
