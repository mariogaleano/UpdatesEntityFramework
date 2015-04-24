using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Business;
using Dtos;
using Entities;
using Microsoft.Ajax.Utilities;

namespace UpdatesEntityFramework.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TrackdtoController : TrackBaseContoller
    {
        public async Task<IHttpActionResult> Put(TrackDto track)
        {
            if(!ModelState.IsValid)
            {
                var result = from ms in ModelState
                             where ms.Value.Errors.Any()
                             let fieldKey = ms.Key
                             let errors = ms.Value.Errors
                             from error in errors
                             select new Error(fieldKey, error.ErrorMessage);

                return BadRequest(ModelState);

            }

            TrackBusiness business = new TrackBusiness();
            return Ok(business.UpdateTrack(track));
        }
    }

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TrackController : TrackBaseContoller
    {
        public async Task<IHttpActionResult> Put(Track track)
        {
            TrackBusiness business = new TrackBusiness();
            return Ok(business.UpdateTrack(track));
        }
    }

    public class TrackBaseContoller : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            TrackBusiness business = new TrackBusiness();
            return Ok(await business.GetAll());
        }

        public async Task<IHttpActionResult> Get(int id)
        {
            TrackBusiness business = new TrackBusiness();
            return Ok(await business.GetTrack(id));
        }
    }
}
