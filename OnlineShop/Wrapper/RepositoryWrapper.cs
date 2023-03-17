using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Controllers;
using OnlineShop.Models;
using OnlineShop.Interfaces;
using OnlineShop.Repositories;

namespace OnlineShop.Wrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private OnlineShopContext _repoContext;

        private IUserRepository _user;

        public IUserRepository User
        {
            get
            {
                if(_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }
        }

        public RepositoryWrapper(OnlineShopContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
