using AutoMapper;
using Entprog.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PAL.app.Models;
using PAL.DataModel;

namespace PAL.app.Controllers
{
    [Authorize]
    public class DACController : Controller
    {
        private readonly IGenericRepository<DACSlot> repo;
        private readonly IGenericRepository<AKICSlot> arepo;
        private readonly IGenericRepository<DOMINGASlot> drepo;
        private readonly IGenericRepository<PETERSlot> prepo;
        private readonly IGenericRepository<CampusReservation> reserverepo;
        private readonly IMapper mapper;
        public DACController(IGenericRepository<DACSlot> repo, IMapper mapper, IGenericRepository<CampusReservation> reserverepo, 
            IGenericRepository<AKICSlot> arepo, IGenericRepository<DOMINGASlot> drepo, IGenericRepository<PETERSlot> prepo)
        {
            this.repo = repo;
            this.mapper = mapper;
            this.prepo = prepo;
            this.reserverepo = reserverepo;
            this.arepo = arepo;
            this.drepo = drepo;
           
        }


        [HttpGet]
        public async Task<IActionResult> Reservation(int DACSlotId, string DACCampus)
        {
            var slot = await repo.GetAsync(DACSlotId);
            if (slot != null && slot.Status == "Unoccupied")
            {
                var reservationVM = new CampusReservationVM
                {
                    Campus = DACCampus,
                    SlotId = DACSlotId,
                    
                };

                return View(reservationVM);
            }
            else
            {
                // Handle the case when the slot is already occupied or does not exist.
                // For example, show an error message or redirect to an error page.
                return View("SlotOccupiedError");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reserve(CampusReservationVM model)
        {
            if (ModelState.IsValid)
            {
                var slot = await repo.GetAsync(model.SlotId);
                model.UserId = User.Identity.Name;

                if (slot != null && slot.Status == "Unoccupied")
                {
                    // Set the slot status to "Occupied" and update the reservation in the database.
                    slot.Status = "Occupied";
                    await repo.UpdateAsync(slot);

                    // Save the reservation to the database using your IGenericRepository.
                    await reserverepo.CreateAsync(mapper.Map<CampusReservation>(model));

                    // Redirect to the reservation details page or any other desired page.
                    return RedirectToAction("DACReservationDetails");
                }
                else
                {
                    // Handle the case when the slot is already occupied or does not exist.
                    // For example, show an error message or redirect to an error page.
                    return View("SlotOccupiedError");
                }
            }
            else
            {
                return View("Reservation", model); // Return back to the reservation form with validation errors.
            }
        }


        public async Task<IActionResult> Edit(int SlotId)
        {
            if (await reserverepo.ExistsAsync(SlotId))
            {
                CampusReservationVM obj = mapper.Map<CampusReservationVM>(await reserverepo.GetAsync(SlotId));
                return View(obj);
            }
            else
            {
                return RedirectToAction("DACIndex", "Campus");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(CampusReservationVM model)
        {
            if (ModelState.IsValid)
            {
                //model.DateModified = DateTime.Now;
                await reserverepo.UpdateAsync(mapper.Map<CampusReservation>(model));
                return RedirectToAction("DACIndex", "Campus");
            }
            else
            {
                return View(model);
            }
        }

        public async Task<IActionResult> DACReservationDetails()
        {
            var reservations = await reserverepo.GetAllAsync();
            var currentTime = DateTime.Now;
            var userId = User.Identity.Name;
            var ureservations = await reserverepo.FindAllAsync(r => r.UserId == userId);

            foreach (var reservation in reservations)
            {
                if (reservation.EndTime <= currentTime)
                {
                    // Reservation's end time has passed, update the associated DACSlot status to "Unoccupied"
                    var slot = await repo.GetAsync(reservation.SlotId);
                    var aslot = await arepo.GetAsync(reservation.SlotId);
                    var dslot = await drepo.GetAsync(reservation.SlotId);
                    var pslot = await prepo.GetAsync(reservation.SlotId);
                    if (slot != null || aslot != null || dslot != null || pslot != null)
                    {
                        slot.Status = "Unoccupied";
                        aslot.Status = "Unoccupied";
                        dslot.Status = "Unoccupied";
                        pslot.Status = "Unoccupied";
                        await repo.UpdateAsync(slot);
                        await arepo.UpdateAsync(aslot);
                        await drepo.UpdateAsync(dslot);
                        await prepo.UpdateAsync(pslot);
                    }
                }
            }

            // Now fetch the updated reservation details and pass them to the view
            var reservationDetails = await reserverepo.GetAllAsync();
            return View(mapper.Map<List<CampusReservationVM>>(reservationDetails));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int CampusReservationId)
        {

            if (await reserverepo.ExistsAsync(CampusReservationId))
            {
                // Get the reservation before deleting it
                var reservation = await reserverepo.GetAsync(CampusReservationId);

                // Delete the reservation
                await reserverepo.DeleteAsync(CampusReservationId);

                // Update the status of the associated DACSlot to "Unoccupied"
                var slot = await repo.GetAsync(reservation.SlotId);
                if (slot != null)
                {
                    slot.Status = "Unoccupied";
                    await repo.UpdateAsync(slot);
                }

            }
            return RedirectToAction("DACReservationDetails");
        }
        public async Task<IActionResult> Payment(int CampusReservationId)
        {

            if (await reserverepo.ExistsAsync(CampusReservationId))
            {
                // Get the reservation before updating it
                var reservation = await reserverepo.GetAsync(CampusReservationId);

                // Update the reservation to indicate that it's paid
                reservation.Paid = true;
                await reserverepo.UpdateAsync(reservation);

                // Redirect to the reservation details page
                return RedirectToAction("DACReservationDetails");
            }

            return RedirectToAction("DACReservationDetails");
        }
    }
}
