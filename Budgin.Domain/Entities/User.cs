using System;
using System.Collections.Generic;

namespace Budgin.Domain.Entities
{
    public class User
    {
        public User(Guid id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;

            Workspaces = new List<Workspace>();
        }

        public Guid Id { get; private set; }
        public String Name { get; private set; }
        public String Email { get; private set; }
        public String Password { get; private set; }
        public List<Workspace> Workspaces { get; set; }
    }
}
