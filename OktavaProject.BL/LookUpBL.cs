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

        public async Task<List<DayDTO>> GetDay()
        {
            List<Day> Day1 = await lookUpDL.GetDays();
            List<DayDTO> Day2 = mapper.Map<List<DayDTO>>(Day1);
            return Day2;
        }


        public async Task<List<HourDTO>> GetHour()
        {
            List<Hour> Hour1 = await lookUpDL.GetHours();
            List<HourDTO> Hour2 = mapper.Map<List<HourDTO>>(Hour1);
            return Hour2;
        }

        public async Task<List<AcademicDegreeDTO>> GetAcademicDegrees()
        {
            List<AcademicDegree> AcademicDegree1 = await lookUpDL.GetAcademicDegrees();
            List<AcademicDegreeDTO> AcademicDegree2 = mapper.Map<List<AcademicDegreeDTO>>(AcademicDegree1);
            return AcademicDegree2;
        }

    }
}
