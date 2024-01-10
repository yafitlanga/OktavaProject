using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class AcademicDegreeUserDL: IAcademicDegreeUserDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<AcademicDegreeUser>> GetAcademicDegreeUsers()
        {
            return await _OktavaContext.AcademicDegreeUsers.ToListAsync();
        }
        public async Task<AcademicDegree> GetEventById(int id)
        {
            try
            {
                var academicDegree = await _OktavaContext.AcademicDegrees.FirstOrDefaultAsync(academicDegree => academicDegree.Id == id);
                return academicDegree;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddAcademicDegreeUser(AcademicDegreeUser _AcademicDegreeUser)
        {
            try
            {
                await _OktavaContext.AcademicDegreeUsers.AddAsync(_AcademicDegreeUser);
                _OktavaContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateAcademicDegreeUsers(AcademicDegreeUser AcademicDegreeUser, int id)
        {
            try
            {
                AcademicDegreeUser AcademicDegreeUserToUpdate = await _OktavaContext.AcademicDegreeUsers.FirstOrDefaultAsync(x => x.Id == id);
                if (AcademicDegreeUserToUpdate != null)
                {
                 AcademicDegreeUserToUpdate.AcademicDegreeId =AcademicDegreeUser.AcademicDegreeId ;
                    AcademicDegreeUserToUpdate.UserId = AcademicDegreeUser.UserId;
                    AcademicDegreeUserToUpdate.Id =AcademicDegreeUser.Id  ;    
                }
                else
                {
                    return false;
                }
                _OktavaContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveAcademicDegreeUser(int id)
        {
            try
            {
                AcademicDegreeUser AcademicDegreeUserToRemove = await _OktavaContext.AcademicDegreeUsers.FirstOrDefaultAsync(x => x.Id == id);
                if (AcademicDegreeUserToRemove != null)
                {
                    _OktavaContext.AcademicDegreeUsers.Remove(AcademicDegreeUserToRemove);
                    _OktavaContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
