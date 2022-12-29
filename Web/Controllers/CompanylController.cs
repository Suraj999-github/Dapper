using BusinessLayer.Business.Company;
using CommonSharingLayer.Models;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{
    public class CompanylController : Controller
    {

        private readonly ICompanyBusiness _companyBusiness;
        public CompanylController(ICompanyBusiness companyBusiness)
        {
            _companyBusiness = companyBusiness;
        }
        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            try
            {
                var companies = await _companyBusiness.GetCompanies();
                return Ok(companies);
            }
            catch (Exception ex)
            {               
                return StatusCode(500, ex.Message);
            }
        }       
        public async Task<IActionResult> GetCompany(int id)
        {
            try
            {
                var company = await _companyBusiness.GetCompany(id);
                if (company == null)
                    return NotFound();

                return Ok(company);
            }
            catch (Exception ex)
            {              
                return StatusCode(500, ex.Message);
            }
        }
       
        public async Task<IActionResult> CreateCompany(CompanyForCreationDto company)
        {
            try
            {
                var createdCompany = await _companyBusiness.CreateCompany(company);
                return CreatedAtRoute("CompanyById", new { id = createdCompany.Id }, createdCompany);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
