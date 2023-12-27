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

        

    }
}
