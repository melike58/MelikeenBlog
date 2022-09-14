﻿using BusinessLAyer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLAyer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public void CategoryAdd(Contact contact)
        {
            _contactdal.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _contactdal.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _contactdal.Update(contact);
        }

        public Contact GetByID(int id)
        {
            return _contactdal.Get(x => x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _contactdal.List();
        }
    }
}