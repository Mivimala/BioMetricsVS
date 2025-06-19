using Bio.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Bio.DAL.Interface
{
    public interface IBioInterface
    {


        public List<Login> GetAll();

    }
}
