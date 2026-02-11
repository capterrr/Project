using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.DepartmentContext.Value_Objects
{
	public record CreatedAt
	{
		public DateTime Value { get; }

        private CreatedAt(DateTime value)
        {
            Value = value;
        }

        public static CreatedAt Create()
        {
            return new(DateTime.UtcNow);
        }
    }
}
