using Entprog.Repository;
using PAL.DataModel;

namespace PAL.app.Models.Repository
{
    public class SlotRepository : GenericRepository<DACSlot>
    {
        public SlotRepository(AppDbContext db) : base(db)
        {

        }
    }
}
