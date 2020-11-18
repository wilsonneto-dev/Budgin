using System;

namespace Budgin.Domain.Entities
{
    public class Account
    {
        public Account(Guid id, string name, Guid workspaceId)
        {
            Id = id;
            Name = name;
            WorkspaceId = workspaceId;
        }

        public Guid Id { get; private set; }
        public String Name { get; private set; }
        
        public Guid WorkspaceId { get; private set; }
        public Workspace Workspace { get; private set; }
    }
}