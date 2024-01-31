using Entprog.Repository;
using PAL.DataModel;

namespace PAL.app.Models.Repository
{
    public class CampusReservationRepository : GenericRepository<CampusReservation>
    {
        public CampusReservationRepository(AppDbContext db) : base(db)
        {

        }
    }
}
