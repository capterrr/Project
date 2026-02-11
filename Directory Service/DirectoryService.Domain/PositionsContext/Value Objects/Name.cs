using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.PositionsContext.Value_Objects
{
    public record Name
    {
        public string Value { get; }

        private Name(string value) => Value = value;

        public static Name Create(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Название должности не может быть пустым", nameof(input));

            if (input.Length > 100)
                throw new ArgumentException("Название должности не должно превышать 100 символов", nameof(input));

            return new Name(input.Trim());
        }
    }
}
