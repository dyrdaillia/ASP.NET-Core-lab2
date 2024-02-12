using System;
using Microsoft.Extensions.Options;

namespace Lab2
{
    public class CompanyService : ICompanyService
    {
        private readonly CompanyConfig _companyConfig;

        public CompanyService(IOptions<CompanyConfig> companyConfig)
        {
            _companyConfig = companyConfig.Value;
        }

        public string GetCompanyWithMostEmployees()
        {
            var maxEmployees = 0;
            var companyWithMostEmployees = "";

            foreach (var company in _companyConfig.Companies)
            {
                if (company.Employees > maxEmployees)
                {
                    maxEmployees = company.Employees;
                    companyWithMostEmployees = company.Name;
                }
            }

            return companyWithMostEmployees;
        }
    }
}
