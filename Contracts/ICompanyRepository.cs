using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        //bool CreateCompany(Company company);
        //bool UpdateCompany(Company company);
        //bool DeleteCompany(Company company);

    }
}
