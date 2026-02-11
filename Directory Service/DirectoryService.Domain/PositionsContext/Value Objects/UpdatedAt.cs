using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.PositionsContext.Value_Objects
{
	public record UpdatedAt
	{
		public DateTime Value { get; }

        private UpdatedAt(DateTime value)
        {
            Value = value;
        }

        public static UpdatedAt Create()
        {
            return new(DateTime.UtcNow);
        }
    }
}
