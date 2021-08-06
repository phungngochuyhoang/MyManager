using System.Collections.Generic;
using System.Linq;
using System;
using Manager.DBContext.Repository;
using Manager.Data.Entities;

namespace Manager.Service
{
    public class AccountService : BaseService<AccountEntity>, IAccountService
    {
        private readonly IRepositoryBase<AccountEntity> _accountRepo;
        public AccountService(IRepositoryBase<AccountEntity> accountRepo) : base(accountRepo)
        {
            _accountRepo = accountRepo;
        }

    }
    
}