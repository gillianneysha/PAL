using Entprog.Repository;
using PAL.DataModel;

namespace PAL.app.Models.Repository
{
    public class DOMINGASlotRepository : GenericRepository<DOMINGASlot>
    {
        public DOMINGASlotRepository(AppDbContext db) : base(db)
        {

        }
    }
}
