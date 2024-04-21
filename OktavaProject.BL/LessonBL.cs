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
    public class LessonBL:ILessonBL
    {
        private ILessonDL lessonDL;
        private IMapper mapper;

        public LessonBL(ILessonDL lessonDL, IMapper _mapper)
        {
            this.lessonDL = lessonDL;
            this.mapper = _mapper;
        }
        public async Task<List<Lesson>> GetLessons()
        {
            return await lessonDL.GetLessons();
        }
        public async Task<LessonDTO> GetLessonById(int id)
        {
            Lesson Lesson1 = await lessonDL.GetLessonsById(id);
            LessonDTO Lesson2 = mapper.Map<LessonDTO>(Lesson1);
            return Lesson2;
        }
        public async Task<List<LessonDTO>> GetLessonByUserId(int UserId)
        {
            List<Lesson> Lesson1 = await lessonDL.GetLessonsByUserId(UserId);
            List<LessonDTO> Lesson2 = mapper.Map<List<LessonDTO>>(Lesson1);
            return Lesson2;
        }
        public async Task<bool> AddLessons(LessonDTO lesson)
        {
            Lesson l = mapper.Map<Lesson>(lesson);
            bool isAdd = await lessonDL.AddLesson(l);
            return isAdd;
        }
        public async Task<bool> UpdateLesson(LessonDTO lesson, int id)
        {
            Lesson l = mapper.Map<Lesson>(lesson);
            bool isUpdate = await lessonDL.UpdateLesson(l, id);
            return isUpdate;
        }
        public async Task<bool> RemoveLesson(int id)
        {
            bool isRemove = await lessonDL.RemoveLesson(id);
            return isRemove;
        }
    }
}
