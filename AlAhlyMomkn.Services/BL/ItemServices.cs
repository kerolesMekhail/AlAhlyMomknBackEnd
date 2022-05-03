using AlAhlyMomkn.DAL.Models;
using AlAhlyMomkn.DTO.ViewModel;
using AlAhlyMomkn.Repository;
using AlAhlyMomkn.Repository.IRepository;
using AlAhlyMomkn.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.Services.BL
{
    public class ItemServices : IItem
    {
        private readonly IRepositoryItem _repository;
        public ItemServices(IRepositoryItem repository)
        {
            _repository = repository;
        }
        
        public bool Add(Item entity)
        {
            try
            {
                if (entity != null)
                {
                    _repository.Add(entity);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Delete(Item entity)
        {
            try
            {
                if (entity != null)
                {
                    _repository.Delete(entity);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public bool Update(Item entity)
        {
            try
            {
                if (entity != null)
                {
                    _repository.Update(entity);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Item GetById(int id)
        {
            try
            {
                var item = _repository.GetById(id);
                return item;
            }
            catch (Exception ex)
            {
                return new Item();
            }
        }
    }
}
