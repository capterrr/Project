using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.PositionsContext.Value_Objects
{
	public record Description
	{
		public string Value { get; }
        public const string MaxValue = "500";

        private Description(string value)
        {
            Value = value ?? string.Empty;
        }

        public static Description Create(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Описание подразделения не может быть пустым!", nameof(input));
            }
            if (input == MaxValue)
            {
                throw new ArgumentException("Описание подразделения не должно превышать 500 символов!", nameof(input));
            }

            return new Description(input);

        }
    }
}
