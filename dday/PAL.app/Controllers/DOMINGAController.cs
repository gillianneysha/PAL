using AutoMapper;
using Entprog.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PAL.app.Models;
using PAL.DataModel;

namespace PAL.app.Controllers
{
    [Authorize]
    public class DOMINGAController : Controller
    {
        private readonly IGenericRepository<DOMINGASlot> repo;
        private readonly IGenericRepository<CampusReservation> reserverepo;
        private readonly IMapper mapper;
        public DOMINGAController(IGenericRepository<DOMINGASlot> repo, IMapper mapper, IGenericRepository<CampusReservation> reserverepo)
        {
            this.repo = repo;
            this.mapper = mapper;
            this.reserverepo = reserverepo;
        }


        [HttpGet]
        public async Task<IActionResult> Reservation(int DOMINGASlotId, string DOMINGACampus)
        {
            var slot = await repo.GetAsync(DOMINGASlotId);
            if (slot != null && slot.Status == "Unoccupied")
            {
                var reservationVM = new CampusReservationVM
                {
                    Campus = DOMINGACampus,
                    SlotId = DOMINGASlotId,

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
                    return RedirectToAction("DACReservationDetails", "DAC");
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
                return RedirectToAction("DomingaIndex", "Campus");
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
                return RedirectToAction("DomingaIndex", "Campus");
            }
            else
            {
                return View(model);
            }
        }

        public async Task<IActionResult> DOMINGAReservationDetails()
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
                    if (slot != null)
                    {
                        slot.Status = "Unoccupied";
                        await repo.UpdateAsync(slot);
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
            return RedirectToAction("DACReservationDetails", "DAC");
        }
    }
}
