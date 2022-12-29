using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSharingLayer.Models;

namespace BusinessLayer.Business.Company
{
    public interface ICompanyBusiness
    {
      Task<List<CompanyModel>> GetCompanies();
      Task<CompanyModel> GetCompany(int id);
      Task<CompanyModel> CreateCompany(CompanyForCreationDto company);
    }
}
