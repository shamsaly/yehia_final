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
    public class StaffController : ControllerBase
    {
        private readonly IgenericRepo<Staff> staffrepo;
        private readonly IgenericRepo<Department> deprepo;
        private readonly IMapper mapper;

        public StaffController(IgenericRepo<Staff>staffrepo,IgenericRepo<Department>deprepo,IMapper mapper)
        {
            this.staffrepo = staffrepo;
            this.deprepo = deprepo;
            this.mapper = mapper;
        }


        [HttpPost]
        public async Task<ActionResult> addstaff(StaffcreateDto dto)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);

            }




            var staff = mapper.Map<StaffcreateDto, Staff>(dto);


            var spec = new DepartmentSpec(dto.Departmentid);


            var department = await deprepo.GetById(spec);

            if (department == null)
            {

                return NotFound("department not found");
            }
            await staffrepo.Add(staff);

            return Ok("Done");
        }




        [HttpGet("{id}")]
        public async Task<ActionResult<Staff>> getbyid(int id)
        {
            


            var spec=new StaffSpec(id);

            var staff= await staffrepo.GetById(spec);    

            if(staff == null)
            {
                return NotFound("Staff not found");
            }
            var staffmapped = mapper.Map<Staff, StaffreturnDto>(staff);
           
            return Ok(staffmapped);

        }


    }
}
