using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dtos;
using Entities;

namespace Data
{
    public class TrackData
    {
        private ChinookEntities context;

        public TrackData()
        {
            context = new ChinookEntities();
            context.Configuration.ProxyCreationEnabled = false;
        }

        public TrackDto UpdateTrack(TrackDto trackDto)
        {
            Mapper.CreateMap<TrackDto, Track>();


            var track = context.Tracks.Find(trackDto.TrackId);

            //var track = Mapper.Map<TrackDto, Track>(trackDto);
            //context.Tracks.Attach(track);

            context.Entry(track).CurrentValues.SetValues(track);
            foreach (var property in typeof(TrackDto).GetProperties().Select(c => c.Name))
            {
                var original = typeof(Track).GetProperty(property).GetValue(track);
                var current = typeof(TrackDto).GetProperty(property).GetValue(trackDto);
                if (!object.Equals(original, current))
                {
                    context.Entry(track).Property(property).IsModified = true;
                }
            }
           
            context.SaveChanges();
            return trackDto;
        }

        public Track UpdateTrack(Track track)
        {
            context.Configuration.ProxyCreationEnabled = false;

            var original = context.Tracks.Local.FirstOrDefault(c => c.TrackId == track.TrackId);
            
            if(original == null)
                original = context.Tracks.FirstOrDefault(c => c.TrackId == track.TrackId);

            if (original != null)
            {
                context.Entry(original).CurrentValues.SetValues(track);
                context.SaveChanges();
            }
            //SaveOnlyChangedValues(context, track);

            return track;
        }

        public async Task<Track> GetTrack(int id)
        {
            return await context.Tracks.FirstOrDefaultAsync(c => c.TrackId == id);
        }

        private void SaveOnlyChangedValues(ChinookEntities db, Track entity)
        {
            db.Tracks.Attach(entity);
            DbEntityEntry entry = db.Entry(entity);

            var dbvalues = entry.GetDatabaseValues();
            foreach (var propertyName in entry.OriginalValues.PropertyNames)
            {
                //var original = entry.OriginalValues.GetValue<object>(propertyName);
                var original = dbvalues.GetValue<object>(propertyName);
                var current = entry.CurrentValues.GetValue<object>(propertyName);
                if (!object.Equals(original, current))
                {
                    entry.Property(propertyName).IsModified = true;
                }
            }
            db.SaveChanges();
        }

        public async Task<List<TrackDto>> GetAll()
        {
            Mapper.CreateMap<Track, TrackDto>();
            var result = await context.Tracks.OrderBy(c => c.TrackId).Skip(3506).Take(5).ToListAsync();
            return Mapper.Map<List<Track>, List<TrackDto>>(result);
        }
    }
}
