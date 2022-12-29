using ServiceLayer.Services.Company;
using CommonSharingLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Business.Company
{
    public class CompanyBusiness: ICompanyBusiness
    {
        private readonly ICompanyService _companyServive;
        public CompanyBusiness(ICompanyService companyServive)
        {
            _companyServive = companyServive;
        }

        public async Task<CompanyModel> CreateCompany(CompanyForCreationDto company)
        {
            var companies = await _companyServive.CreateCompany(company);
            return (CompanyModel)companies;
          
        }

        public async Task<List<CompanyModel>> GetCompanies()
        {
            var companies = await _companyServive.GetCompanies();
            return (List<CompanyModel>)companies;            
        }
        public async Task<CompanyModel> GetCompany(int id)
        {
            var companies = await _companyServive.GetCompany(id);
            return (CompanyModel)companies;
        }
        
    }
}
