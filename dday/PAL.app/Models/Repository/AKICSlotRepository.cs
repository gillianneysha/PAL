using Entprog.Repository;
using PAL.DataModel;

namespace PAL.app.Models.Repository
{
    public class AKICSlotRepository : GenericRepository<AKICSlot>
    {
        public AKICSlotRepository(AppDbContext db) : base(db)
        {

        }
    }
}
