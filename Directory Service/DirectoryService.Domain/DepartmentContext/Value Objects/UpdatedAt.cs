using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.DepartmentContext.Value_Objects
{
    public record UpdatedAt
    {
        public DateTime Value { get; }
        
        private UpdatedAt(DateTime value) => Value = value;

        public static UpdatedAt Create() => new(DateTime.UtcNow);

    }
}
