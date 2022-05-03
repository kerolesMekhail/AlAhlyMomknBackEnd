using AlAhlyMomkn.DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.DAL.Models
{
    public partial class Item
    {
        public static Item Clone(ItemDto itemDto)
        {
            Item item = new Item()
            {
               Id = itemDto.Id,
               Description = itemDto.Description,
               StepId=itemDto.stepId,
               Title= itemDto.Title,    
            };
            return item;
        }
        public static ItemDto Clone(Item item)
        {
            ItemDto itemDto = new ItemDto()
            {
                Id = item.Id,
                Description = item.Description,
                stepId = item.StepId,
                Title = item.Title,
            };
            return itemDto;
        }
    }
}
