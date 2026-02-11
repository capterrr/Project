using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.PositionsContext.Value_Objects
{
    public record Description
    {
        public string Value { get; }

        private Description(string value) => Value = value ?? string.Empty;

        public static Description Create(string? input)
        {
            if (input != null && input.Length > 500)
                throw new ArgumentException("Описание должности не должно превышать 500 символов", nameof(input));

            return new Description(input);
        }
    }
}
