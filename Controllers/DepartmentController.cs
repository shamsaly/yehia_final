using AutoMapper;
using Final_Project.DTO;
using Final_Project.Generic;
using Final_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IgenericRepo<Department> departmentrepo;
        private readonly IMapper mapper;

        public DepartmentController( IgenericRepo<Department>departmentrepo,IMapper mapper   )
        {
            this.departmentrepo = departmentrepo;
            this.mapper = mapper;
        }




        [HttpPost]
        public async Task<ActionResult> create(DepartmentCreateDto dto)
        {

            if (!ModelState.IsValid) { 
            
            
            return BadRequest(ModelState);
            
            }

            var mapped =mapper.Map<DepartmentCreateDto,Department>(dto);
            await departmentrepo.Add(mapped);
            return Ok("Add");





        }



    }
}
