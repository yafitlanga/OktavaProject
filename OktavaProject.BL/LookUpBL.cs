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
    public class LookUpBL: ILookUpBL
    {
        private ILookUpDL lookUpDL;
        private IMapper mapper;

        public LookUpBL(ILookUpDL lookUpDL, IMapper _mapper)
        {
            this.lookUpDL = lookUpDL;
            this.mapper = _mapper;
        }
        
        public async Task<List<SkillDTO>> GetSkills()
        {
            List<Skill> Skill1 = await lookUpDL.GetSkills();
            List<SkillDTO> Skill2 = mapper.Map<List<SkillDTO>>(Skill1);
            return Skill2;
        }
        public async Task<SkillDTO> GetSkillById(int id)
        {
            Skill skill1 = await lookUpDL.GetSkillById(id);
            SkillDTO skill2 = mapper.Map<SkillDTO>(skill1);
            return skill2;
        }

        public async Task<List<DayDTO>> GetDay()
        {
            List<Day> Day1 = await lookUpDL.GetDays();
            List<DayDTO> Day2 = mapper.Map<List<DayDTO>>(Day1);
            return Day2;
        }
        public async Task<DayDTO> GetDayById(int id)
        {
            Day Day1 = await lookUpDL.GetDayById(id);
            DayDTO Day2 = mapper.Map<DayDTO>(Day1);
            return Day2;
        }


        public async Task<List<HourDTO>> GetHour()
        {
            List<Hour> Hour1 = await lookUpDL.GetHours();
            List<HourDTO> Hour2 = mapper.Map<List<HourDTO>>(Hour1);
            return Hour2;
        }
        public async Task<HourDTO> GetHourById(int id)
        {
            Hour Hour1 = await lookUpDL.GetHourById(id);
            HourDTO Hour2 = mapper.Map<HourDTO>(Hour1);
            return Hour2;
        }

        public async Task<List<AcademicDegreeDTO>> GetAcademicDegrees()
        {
            List<AcademicDegree> AcademicDegree1 = await lookUpDL.GetAcademicDegrees();
            List<AcademicDegreeDTO> AcademicDegree2 = mapper.Map<List<AcademicDegreeDTO>>(AcademicDegree1);
            return AcademicDegree2;
        }
        public async Task<AcademicDegreeDTO> GetAcademicDegreeById(int id)
        {
            AcademicDegree AcademicDegree1 = await lookUpDL.GetAcademicDegreeById(id);
            AcademicDegreeDTO AcademicDegree2 = mapper.Map<AcademicDegreeDTO>(AcademicDegree1);
            return AcademicDegree2;
        }

        public async Task<List<SkillDTO>> GetSkillsByUserId(int userId)
        {
            List<Skill> skills1 = await lookUpDL.GetSkillsByUserId(userId);
            List<SkillDTO> skills2 = mapper.Map<List<SkillDTO>>(skills1);
            return skills2;
        }
    }
}
