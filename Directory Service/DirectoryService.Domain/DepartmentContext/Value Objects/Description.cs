using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DirectoryService.Domain.DepartmentContext.Value_Objects
{
    public record Description
    {
        public string Value { get; }
        
        private Description(string value) => Value = value ?? string.Empty;

        public static Description Create(string? input)
        {
            if (input != null && input.Length > 500) 
                throw new ArgumentException("Описание подразделения не должно превышать 500 символов!",nameof(input));
            
            return new Description(input);
        }
    }
}
