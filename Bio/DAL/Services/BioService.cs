using Bio.DAL.Interface;
using Bio.Model.Entity;
using Bio.Data.Contedxt;
using Bio.Model.Entity;
using Bio.Model.ViewModel;


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

//arthi123
//vimala123

//james 123


            return result;
        }
    }
}
