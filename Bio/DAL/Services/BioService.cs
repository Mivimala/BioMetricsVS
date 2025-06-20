using Bio.DAL.Interface;
using Bio.Model.Entity;
using Bio.Controllers;
using Bio.Model.ViewModel;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Bio.Data;


namespace Bio.DAL.Services
{
    public class BioService : IBioInterface
    {


        private readonly BioContext _bioContext;
      public BioService(BioContext bioContext)
            
        {
            _bioContext = bioContext;
        }

        public List<Login> GetAll()
        {
            var result = _bioContext.Login.ToList();

            if (result.Any())
            {
                return result;
            }
            else

                return new List<Login>();
        }
    }
}
