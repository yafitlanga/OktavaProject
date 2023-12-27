using AutoMapper;
using OktavaProject.DL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.BL
{
    public class StudentLessonBL:IStudentLessonBL
    {
        private IStudentLessonDL studentLessonDL;
        private IMapper mapper;

        public StudentLessonBL(IStudentLessonDL studentLessonDL, IMapper _mapper)
        {
            this.studentLessonDL = studentLessonDL;
            this.mapper = _mapper;
        }
        public async Task<List<StudentLessonDTO>> GetStudentLessons()
        {
            List<StudentLesson> studentLesson1 = await studentLessonDL.GetStudentLessons();
            List<StudentLessonDTO> studentLesson2 = mapper.Map<List<StudentLessonDTO>>(studentLesson1);
            return studentLesson2;
        }
        public async Task<StudentLessonDTO> GetStudentLessonById(int id)
        {
            StudentLesson studentLesson1 = await studentLessonDL.GetStudentLessonById(id);
            StudentLessonDTO studentLesson2 = mapper.Map<StudentLessonDTO>(studentLesson1);
            return studentLesson2;
        }
        public async Task<bool> AddStudentLesson(StudentLessonDTO StudentLesson)
        {
            StudentLesson u = mapper.Map<StudentLesson>(StudentLesson);
            bool isAdd = await studentLessonDL.AddStudentLesson(u);
            return isAdd;
        }
        public async Task<bool> UpdateStudentLesson(StudentLessonDTO studentLesson, int id)
        {
            StudentLesson u = mapper.Map<StudentLesson>(studentLesson);
            bool isUpdate = await studentLessonDL.UpdateStudentLesson(u, id);
            return isUpdate;
        }
        public async Task<bool> RemoveStudentLesson (int id)
        {
            bool isRemove =   await studentLessonDL.RemoveStudentLesson(id);
            return isRemove;
        }
    }
}

