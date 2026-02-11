using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.DepartmentContext.Value_Objects
{
	public record Name
	{
		public const int MaxValue = 128;
		public string Value { get; }

		private Name(string value)
		{
			Value = value;
		}

		public static Name Create(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException(nameof(input), "Название подразделения не может быть пустым!");
            }

            if (input.Length > MaxValue)
            {
                throw new ArgumentException(
					$"Название подразделения не должно превышать {MaxValue} символов!",
					nameof(input)
				);
            }

            return new Name(input.Trim());
		}
	}
}
