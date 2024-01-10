﻿using OktavaProject.DL.Models;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public interface IAcademicDegreeUserDL
    {
        Task<List<AcademicDegreeUser>> GetAcademicDegreeUsers();
        Task<bool> UpdateAcademicDegreeUsers(AcademicDegreeUser AcademicDegreeUser, int id);
        Task<bool> RemoveAcademicDegreeUser(int id);
        Task<bool> AddAcademicDegreeUser(AcademicDegreeUser _AcademicDegreeUser);
        Task<AcademicDegree> GetEventById(int id);
    }
}