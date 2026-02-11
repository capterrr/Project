using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.DepartmentContext.Value_Objects
{
	public record Identifier
	{
		public string Value { get; }

        private Identifier(string value)
        {
            Value = value;
        }

        public static Identifier Create(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Идентификатор подразделения не может быть пустым!", nameof(input));
            }

            if (input.Length > 100)
            {
                throw new ArgumentException(
					"Идентификатор подразделения не дожен превышать 50 символов!",
					nameof(input)
				);
            }

            return new Identifier(input.ToLowerInvariant());
		}
	}
}
