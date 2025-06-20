using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bio.DAL.Interface;
using Bio.Model;

using Bio.Model.Entity;
using Bio.Data;

namespace Bio.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class BioController : ControllerBase
    {
        public readonly BioContext _ibioContext;
        public readonly IBioInterface _ibiointerface;
        public BioController( BioContext bioContext,IBioInterface bioInterface)
        {
            _ibioContext = bioContext;
            _ibiointerface = bioInterface;
        }


        [HttpGet]
        public List<Login> GetAll()
        {
            return _ibiointerface.GetAll();
        }








    }
}
