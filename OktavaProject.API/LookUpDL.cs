using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
  
    public class LookUpDL:ILookUpDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<Skill>> GetSkills()
        {
            try
            {
                var Skills = await _OktavaContext.Skills.ToListAsync();
                return Skills;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<Skill> GetSkillById(int id)
        {
            try
            {
                var Skill = await _OktavaContext.Skills.FirstOrDefaultAsync(Skill => Skill.Id == id);
                return Skill;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Day> GetDayById(int id)
        {
            try
            {
                var Day = await _OktavaContext.Days.FirstOrDefaultAsync(Day => Day.Id == id);
                return Day;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Day>> GetDays()
        {
            try
            {
                var Day = await _OktavaContext.Days.ToListAsync();
                return Day;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<AcademicDegree> GetAcademicDegreeById(int id)
        {
            try
            {
                var AcademicDegree = await _OktavaContext.AcademicDegrees.FirstOrDefaultAsync(AcademicDegree => AcademicDegree.Id == id);
                return AcademicDegree;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<AcademicDegree>> GetAcademicDegrees()
        {
            try
            {
                var AcademicDegree = await _OktavaContext.AcademicDegrees.ToListAsync();
                return AcademicDegree;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<List<Hour>> GetHours()
        {
            try
            {
                var Hour = await _OktavaContext.Hours.ToListAsync();
                return Hour;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<Hour> GetHourById(int id)
        {
            try
            {
                var Hour = await _OktavaContext.Hours.FirstOrDefaultAsync(Hour => Hour.Id == id);
                return Hour;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
