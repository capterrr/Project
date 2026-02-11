using DirectoryService.Domain.LocationContext.ValueObjects;

namespace DirectoryService.Domain.LocationContext
{
    public class Location
    {
        public LocationId Id { get; }
        public LocationAddress Address { get; }
        public LocationName Name { get; }
        public EntityLifeTime LifeTime { get; }
        public IanaTimeZone TimeZone { get; }


        private Location(
            LocationId id,
            LocationAddress address,
            LocationName name,
            EntityLifeTime lifeTime, 
            IanaTimeZone timeZone
            )
        {
            Id = id;
            Name = name;
            Address = address;
            LifeTime = lifeTime;
            TimeZone = timeZone;
        }
    }
}
