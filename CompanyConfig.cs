using System.Collections.Generic;

namespace Lab2
{
    public class CompanyConfig
    {
        public List<Company> Companies { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }
        public int Employees { get; set; }
    }
}
