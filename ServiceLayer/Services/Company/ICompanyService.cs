using CommonSharingLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Company
{
    public interface ICompanyService
    {
        Task<List<CompanyModel>> GetCompanies();
        Task<CompanyModel> GetCompany(int id);
        Task<CompanyModel> CreateCompany(CompanyForCreationDto company);

    }
}
