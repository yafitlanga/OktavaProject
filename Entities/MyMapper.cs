using AutoMapper;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProjectEntities
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO, Student>();
            CreateMap<Contact, ContactDTO>();
            CreateMap<ContactDTO, Contact>();
            CreateMap<EventUpdateUser, EventUpdateUserDTO>();
            CreateMap<EventUpdateUserDTO, EventUpdateUser>();
            CreateMap<Event, EventDTO>();
            CreateMap<EventDTO, Event>();
            CreateMap<Skill, SkillDTO>();
            CreateMap<SkillDTO, Skill>();
            CreateMap<AcademicDegree, AcademicDegreeDTO>();
            CreateMap<AcademicDegreeDTO, AcademicDegree>();
            CreateMap<Day, DayDTO>();
            CreateMap<DayDTO, Day>();
            CreateMap<Hour, HourDTO>();
            CreateMap<HourDTO, Hour>();
            CreateMap<SkillUser, SkillUserDTO>();
            CreateMap<SkillUserDTO, SkillUser>();
            CreateMap<AcademicDegreeUser, AcademicDegreeUserDTO>();
            CreateMap<AcademicDegreeUserDTO, AcademicDegreeUser>();
            CreateMap<Lesson, LessonDTO>();
            CreateMap<LessonDTO, Lesson>();
            CreateMap<StudentLesson, StudentLessonDTO>();
            CreateMap<StudentLessonDTO, StudentLesson>();
            CreateMap<Student, StudentSimpleDTO>();
            CreateMap<StudentSimpleDTO, Student>();
            CreateMap<Event, EventSimpleDTO>();
            CreateMap<EventSimpleDTO, Event>();
        }
    }
}
