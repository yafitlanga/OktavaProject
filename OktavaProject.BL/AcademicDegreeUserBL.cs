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
    public class AcademicDegreeUserBL : IAcademicDegreeUserBL
    {
        private IAcademicDegreeUserDL academicDegreeUserDL;
        private IMapper mapper;

        public AcademicDegreeUserBL(IAcademicDegreeUserDL academicDegreeUserDL, IMapper _mapper)
        {
            this.academicDegreeUserDL = academicDegreeUserDL;
            this.mapper = _mapper;
        }
        public async Task<List<AcademicDegreeUserDTO>> GetAcademicDegreeUsers()
        {
            List<AcademicDegreeUser> academicDegreeUser1 = await academicDegreeUserDL.GetAcademicDegreeUsers();
            List<AcademicDegreeUserDTO> academicDegreeUser2 = mapper.Map<List<AcademicDegreeUserDTO>>(academicDegreeUser1);
            return academicDegreeUser2;
        }
        public async Task<bool> AddAcademicDegreeUser(AcademicDegreeUserDTO _AcademicDegreeUser)
        {
            AcademicDegreeUser a = mapper.Map<AcademicDegreeUser>(_AcademicDegreeUser);
            bool isAdd = await academicDegreeUserDL.AddAcademicDegreeUser(a);
            return isAdd;
        }
        public async Task<bool> UpdateAcademicDegreeUser(AcademicDegreeUserDTO AcademicDegreeUser, int id)
        {
            AcademicDegreeUser u = mapper.Map<AcademicDegreeUser>(AcademicDegreeUser);
            bool isUpdate = await academicDegreeUserDL.UpdateAcademicDegreeUsers(u, id);
            return isUpdate;
        }
        public async Task<bool> RemoveAcademicDegreeUser(int id)
        {
            bool isRemove = await academicDegreeUserDL.RemoveAcademicDegreeUser(id);
            return isRemove;
        }
        public async Task<bool> RemoveAcademicDegreeUserByUserId(int id)
        {
            bool isRemove = await academicDegreeUserDL.RemoveAcademicDegreeUserByUserId(id);
            return isRemove;
        }
    }
}
