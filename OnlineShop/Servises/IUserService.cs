using OnlineShop.Interfaces;
using OnlineShop.Models;
using OnlineShop.Wrapper;
using OnlineShop.Repositories;
using OnlineShop.Controllers;
using OnlineShop.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace OnlineShop.Services
{
    public class UserService : IUserService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public void IUserService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public Task<List<User>> GetAll()
        {
            return _repositoryWrapper.User.FindAll().ToListAsync();
        }
        public Task<User> GetById(int id)   
        {
            var user = _repositoryWrapper.User
            .FindByCondition(x => x.UsersId == id).FirstAsync();
            return Task.FromResult(user.Result);
        }
        public Task Create(User model)
        {
            _repositoryWrapper.User.Create(model);
            _repositoryWrapper.Save();
            return Task.CompletedTask;
        }
        public Task Update(User model)
        {
            _repositoryWrapper.User.Update(model);
            _repositoryWrapper.Save();
            return Task.CompletedTask;
        }
        public Task Delete(int id)
        {
            var user = _repositoryWrapper.User
            .FindByCondition(x => x.UsersId == id).FirstAsync();
            _repositoryWrapper.User.Delete(user.Result);
            _repositoryWrapper.Save();
            return Task.CompletedTask;
        }
    }
}