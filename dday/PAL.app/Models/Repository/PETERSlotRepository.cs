using Entprog.Repository;
using PAL.DataModel;

namespace PAL.app.Models.Repository
{
    public class PETERSlotRepository : GenericRepository<PETERSlot>
    {
        public PETERSlotRepository(AppDbContext db) : base(db)
        {

        }
    }
}
