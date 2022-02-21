using SampleWebpage.Data;
using SampleWebpage.Models;
using SampleWebpage.Services.Interface;

namespace SampleWebpage.Services
{
    public class CollectServices : ICollectServices
    {
        SampleDbContext dbcontext;
        public CollectServices(SampleDbContext dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        public Collect Add(Collect collect)
        {
            dbcontext.Add(collect);
            dbcontext.SaveChanges();
            return collect;
        }

        public Collect Delete(int id, Collect collect)
        {
            throw new NotImplementedException();
        }

        public Collect Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Collect> GetAll()
        {
           return dbcontext.Example2.ToList();
           
        }

        public Collect Update(int id, Collect collect)
        {
            throw new NotImplementedException();
        }
    }
}
