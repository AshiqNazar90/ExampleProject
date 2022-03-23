using SampleWebpage.Models;

namespace SampleWebpage.Services.Interface
{
    public interface ICollectServices
    {
        public Collect Add(Collect collect);
        public Collect AddAdmin(Collect collect);
        public List<Collect> GetAll();
        public Collect Get(int  id);
        public Collect Update(int id, Collect collect);

        public Collect Delete(int id, Collect collect);
    
    }
}
