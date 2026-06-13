using AutoMapper;
using Final_Project.DTO;
using Final_Project.Models;

namespace Final_Project.Mappingprofile
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            // add new department
            CreateMap<DepartmentCreateDto, Department>();

            //add new staff
            CreateMap<StaffcreateDto,Staff>();  


            //get by id for staff
            CreateMap<Department,DepartmentCreateDto>();
            CreateMap<Staff,StaffreturnDto>();

            //add new guest
            CreateMap<RoomCreateDto,Room>();
            CreateMap<GuestcreateDto, Guest>().ForMember(d => d.staff, o => o.Ignore());

            //get all guest
            CreateMap<Room,RoomCreateDto>();
            CreateMap<Staff,StaffreturnDtoforguest>();  
            CreateMap<Guest,GuestReturnDto>();  


        }
    }
}
