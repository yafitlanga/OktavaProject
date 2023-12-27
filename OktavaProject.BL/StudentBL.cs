using AutoMapper;
using OktavaProject.DL.Models;
using OktavaProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public class StudentBL : IStudentBL
    {
        private IStudentDL studentDL;
        private IMapper mapper;

        public StudentBL(IStudentDL studentDL, IMapper _mapper)
        {
            this.studentDL = studentDL;
            this.mapper = _mapper;
        }
        public async Task<List<StudentDTO>> GetStudents()
        {
            List<Student> student1 = await studentDL.GetStudents();
            List<StudentDTO> student2 = mapper.Map<List<StudentDTO>>(student1);
            return student2;
        }
        public async Task<StudentDTO> GetStudentById(int id)
        {
            Student student1 = await studentDL.GetStudentById(id);
            StudentDTO Student2 = mapper.Map<StudentDTO>(student1);
            return Student2;
        }
        public async Task<bool> AddStudent(StudentDTO student)
        {
            Student u = mapper.Map<Student>(student);
            bool isAdd = await studentDL.AddStudent(u);
            return isAdd;
        }
        public async Task<bool> UpdateStudent(StudentDTO student, int id)
        {
            Student u = mapper.Map<Student>(student);
            bool isUpdate = await studentDL.UpdateStudent(u, id);
            return isUpdate;
        }
        public async Task<bool> RemoveStudent(int id)
        {
            bool isRemove = await studentDL.RemoveStudent(id);
            return isRemove;
        }
    }
}
