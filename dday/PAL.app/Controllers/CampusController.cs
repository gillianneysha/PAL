using AutoMapper;
using Entprog.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PAL.app.Models;
using PAL.DataModel;

namespace PAL.app.Controllers
{
    [Authorize]
    public class CampusController : Controller
    {
        private readonly IGenericRepository<DACSlot> repo;
        private readonly IGenericRepository<AKICSlot> akicrepo;
        private readonly IGenericRepository<PETERSlot> prepo;
        private readonly IGenericRepository<DOMINGASlot> drepo;
        private readonly IMapper mapper;

        public CampusController(IGenericRepository<DACSlot> repo, IGenericRepository<AKICSlot> akicrepo, 
            IGenericRepository<PETERSlot> prepo, IGenericRepository<DOMINGASlot> drepo, IMapper mapper)
        {
            this.prepo = prepo;
            this.drepo = drepo;
            this.akicrepo = akicrepo;
            this.repo = repo;
            this.mapper = mapper;
        }

       
        public async Task<IActionResult> DACIndex()
        {
            return View(mapper.Map<List<DACSlotVM>>(await repo.GetAllAsync()));
        }
       
        public async Task<IActionResult> AKICIndex()
        {
            return View(mapper.Map<List<AKICSlotVM>>(await akicrepo.GetAllAsync()));
        }
     
        public async Task<IActionResult> DomingaIndex()
        {
            return View(mapper.Map<List<DOMINGASlotVM>>(await drepo.GetAllAsync()));
        }
        public async Task<IActionResult> PeterIndex()
        {
            return View(mapper.Map<List<PETERSlotVM>>(await prepo.GetAllAsync()));
        }
    }
}
