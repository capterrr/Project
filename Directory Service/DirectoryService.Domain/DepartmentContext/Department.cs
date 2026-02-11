using System;
using System.Collections.Generic;
using System.Text;
using DirectoryService.Domain.DepartmentContext.Value_Objects;

namespace DirectoryService.Domain.DepartmentContext
{
    internal class Department
    {
        public Guid Id { get; }
        public Name Name { get; }
        public Identifier Identifier { get; }
        public Description Description { get; }
        public Guid? ParentId { get; }
        public Value_Objects.Path Path { get; }
        public int Depth => Path.Depth;
        public IsActive IsActive { get; }
        public CreatedAt CreatedAt { get; }
        public UpdatedAt UpdatedAt { get; }


        private Department(
            Guid id,
            Name name,
            Identifier identifier,
            Description description,
            Guid? parentId,
            Value_Objects.Path path,
            IsActive isActive,
            CreatedAt createdAt,
            UpdatedAt updatedAt)
        {
            Id = id;
            Name = name;
            Identifier = identifier;
            Description = description;
            ParentId = parentId;
            Path = path;
            IsActive = isActive;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;

        }














    }
}
