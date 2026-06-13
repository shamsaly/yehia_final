using AutoMapper;
using Final_Project.DTO;
using Final_Project.Generic;
using Final_Project.Models;
using Final_Project.Specification;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IgenericRepo<Guest> guestrepo;
        private readonly IgenericRepo<Staff> staffrepo;
        private readonly IMapper mapper;

        public GuestController(IgenericRepo<Guest>guestrepo,IgenericRepo<Staff>staffrepo,IMapper mapper)
        {
            this.guestrepo = guestrepo;
            this.staffrepo = staffrepo;
            this.mapper = mapper;
        }


        [HttpPost]
        public async Task<ActionResult> addguest(GuestcreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var guest = mapper.Map<GuestcreateDto, Guest>(dto);


            if (dto.staffides != null)
            {


                foreach (var staffid in dto.staffides)
                {

                    var spec = new StaffSpec(staffid);
                    var existingstaff = await staffrepo.GetById(spec);
                    if (existingstaff == null)
                    {

                        return NotFound("staff id not found");


                    }
                    else
                    {
                        guest.staff.Add(existingstaff);

                    }




                }


            }


            await guestrepo.Add(guest);
            return Ok("done");


        }

        [HttpGet]
        public async Task<ActionResult> getallguest()
        {
            var spec = new GuestSpec();
            var guests=await guestrepo.GetAll(spec);

            var mapped = mapper.Map<IEnumerable<Guest>, IEnumerable<GuestReturnDto>>(guests);

            return Ok   (mapped);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult>updateguest(GuestcreateDto dto,int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gspec=new GuestSpec(id);
            var guest=await guestrepo.GetById(gspec);
            if (guest == null)
            {
                return NotFound("guest id not found");

            }


            mapper.Map(dto, guest);

            if (dto.staffides != null)
            {
                guest.staff = new List<Staff>();
                foreach(var staffid in dto.staffides)
                {
                    var sspec = new StaffSpec(staffid);
                    var existingstaff=await staffrepo.GetById(sspec);
                    if (existingstaff == null)
                    {
                        return NotFound("staff id not found");
                    }
                    else
                    {
                        guest.staff.Add(existingstaff); 
                    }

                }



            }

            await guestrepo.Update(guest);
            return Ok("updated");

        }
        [HttpDelete("{id}")]
    public async Task<ActionResult>deleteguest(int id)
        {

            var spec = new GuestSpec(id);
            var guest = await guestrepo.GetById(spec);

            if (guest == null)
            {
                return NotFound("guest id not found");
            }

            await guestrepo.Delete(guest);
            return Ok("deleted guest");


        }
    
    }
}
