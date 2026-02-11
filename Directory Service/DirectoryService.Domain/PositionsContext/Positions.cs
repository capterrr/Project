using System;
using System.Collections.Generic;
using System.Text;
using DirectoryService.Domain.PositionsContext.Value_Objects;

namespace DirectoryService.Domain.PositionsContext
{
	public class Position
	{
		public Guid Id { get; }
		public Name Name { get; }
		public Description Description { get; }
		public IsActive IsActive { get; }
		public CreatedAt CreatedAt { get; }
		public UpdatedAt UpdatedAt { get; }

		private Position(
			Guid id,
			Name name,
			Description description,
			IsActive isActive,
			CreatedAt createdAt,
			UpdatedAt updatedAt
		)
		{
			Id = id;
			Name = name;
			Description = description;
			IsActive = isActive;
			CreatedAt = createdAt;
			UpdatedAt = updatedAt;
		}
	}
}
