using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.DepartmentContext.Value_Objects
{
	public record Path
	{
		public string Value { get; }

        private Path(string value)
        {
            Value = value;
        }

        public static Path Restore(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Путь подразделения не может быть пустым", nameof(value));
            }

            /*if (value.Contains("..") || value.StartsWith(".") || value.EndsWith("."))
            {
                throw new ArgumentException("Некорректный формат пути подразделения", nameof(value));
            }*/

            return new Path(value);
		}

		public int Depth => Value.Split('.').Length - 1;
	}
}
