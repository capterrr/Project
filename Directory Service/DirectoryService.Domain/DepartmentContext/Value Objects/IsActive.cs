using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.DepartmentContext.Value_Objects
{
    public record IsActive
    {
        public bool Value { get; }

        private IsActive(bool value) => Value = value;

        public static IsActive Create(bool value) => new(value);
    }
}
