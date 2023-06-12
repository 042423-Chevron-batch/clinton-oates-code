using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rps_Models;
using Rps_Repository;

namespace Rps_Business
{
    public class BusinessLayerClassLibrary
    {
        public List<Store> GetStores()
        {
            Rps_RepoLayerClassLibrary repo = new Rps_RepoLayerClassLibrary();

            List<Store> stores = repo.GetStores();

            if (stores.Count > 0)
            {
                return stores;
            }
            else
            {
                return null;
            }

        }

        public Person Login(string username, string password)
        {
            Rps_RepoLayerClassLibrary repo = new Rps_RepoLayerClassLibrary();

            // send the username and password to repo layer.
            Person p = repo.GetUserByUnamePword(username, password);
            return p;
        }

        public Person Register(RegisterDto dto)
        {
            // 1. do someting to the data if necessary.
            //UserNamePasswordInDb
            Rps_RepoLayerClassLibrary repo = new Rps_RepoLayerClassLibrary();
            // 2. call a repo layer method to check if the username/password combo is in the DB.
            // 1st call to repo layer
            bool ret = repo.UserNamePasswordInDb(dto.UserName, dto.Password);
            if (!ret)
            {
                //create a new Person object to get a GUID id.
                //2nd call to repo layer
                Person p = Mapper.RegisterDtoToPerson(dto);

                // 3. call a repo layer method to put this data into the Db.
                // 3rd call to repo layer
                int numRowsAffected = repo.RegisterNewCustomer(p);
                if (numRowsAffected == 1)
                {
                    //call another repo method that will get a person by usernames and password
                    //4th call to repo layer
                    Person p1 = repo.GetUserByUnamePword(p.UserName, p.Password);
                    return p1;
                }
            }
            return null;
        }

        public Store StoreInfo(Guid storeId)
        {
            Rps_RepoLayerClassLibrary repo = new Rps_RepoLayerClassLibrary();
            Store s = repo.StoreInfo(storeId);
            if (s != null) return s;
            else return null;
        }
    }
}