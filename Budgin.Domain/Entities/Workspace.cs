using System;
using System.Collections.Generic;

namespace Budgin.Domain.Entities
{
    public class Workspace
    {
        public Workspace(Guid id, string name)
        {
            Id = id;
            Name = name;

            Users = new List<User>();
        }

        public Guid Id { get; private set; }
        public String Name { get; private set; }

        public List<User> Users { get; set; }
        public List<Account> Accounts { get; set; }
    }
}