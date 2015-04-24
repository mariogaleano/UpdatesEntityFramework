using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Dtos;
using Entities;

namespace Business
{
    public class TrackBusiness
    {
        private readonly TrackData trackData;

        public TrackBusiness()
        {
            trackData = new TrackData();
        }

        public TrackDto UpdateTrack(TrackDto trackDto)
        {
            return trackData.UpdateTrack(trackDto);
        }

        public Track UpdateTrack(Track trackDto)
        {
            
            return trackData.UpdateTrack(trackDto);
        }

        public async Task<List<TrackDto>> GetAll()
        {
            return await trackData.GetAll();
        }

        public async Task<Track> GetTrack(int id)
        {
            return await trackData.GetTrack(id);
        }
    }
}
