using System;
using System.ComponentModel.DataAnnotations;
using Manager.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Manager.Models
{
    public class AccountModel
    {
        public string AccountName { get; set; }       
        public string Password { get; set; }

    }

    public static class AccountFunc 
    {
        public static AccountEntity toEntity(this AccountModel model, AccountEntity entity) {

            entity.AccountName = model.AccountName;
            entity.Password = model.Password;

            return entity;
        }

        public static AccountModel toModel(this AccountEntity entity) {
            var model = new AccountModel();
            model.AccountName = entity.AccountName;
            model.Password = entity.Password;

            return model;
        }
        public static IList<AccountModel> toListModel(this IList<AccountEntity> entities) {

            return entities.Select(p => p.toModel()).ToList();
        }


    }
}