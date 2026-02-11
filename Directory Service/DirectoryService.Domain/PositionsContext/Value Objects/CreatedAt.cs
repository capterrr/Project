using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryService.Domain.PositionsContext.Value_Objects
{
    public record CreatedAt
    {
        public DateTime Value { get; }

        private CreatedAt(DateTime value) => Value = value;

        public static CreatedAt Create() => new(DateTime.UtcNow);
    }
}
