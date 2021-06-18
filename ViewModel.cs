using System.Collections.ObjectModel;

namespace SfTreeGridDemo
{
    public class ViewModel
    {
        public ViewModel()
        {
            GetEmployees();
        }
        private ObservableCollection<EmployeeInfo> _employees;

        public ObservableCollection<EmployeeInfo> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;

            }
        }

        private void GetEmployees()
        {
            //await Task.Delay(5000);
            ObservableCollection<EmployeeInfo> employeeDetails = new ObservableCollection<EmployeeInfo>();
            employeeDetails.Add(new EmployeeInfo() { FirstName = "ferando", Title = "management", Salary = 2000000, ReportsTo = -1, ID = 2, IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "john", LastName = "adams", Title = "accounts", Salary = 2000000, ReportsTo = -1, ID = 3, IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "thomas", LastName = "jefferson", Title = "sales", Salary = 300000, ReportsTo = -1, ID = 4, IsMissing = false });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "andrew", LastName = "madison", Title = "marketing", Salary = 4000000, ReportsTo = -1, ID = 5, IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "ulysses", LastName = "pierce", Title = "humanresource", Salary = 1500000, ReportsTo = -1, ID = 6, IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "jimmy", LastName = "harrison", Title = "purchasing", Salary = 200000, ReportsTo = -1, ID = 7, IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "ronald", LastName = "fillmore", Title = "production", Salary = 2800000, ReportsTo = -1, ID = 8, IsMissing = false });
            //Management

            employeeDetails.Add(new EmployeeInfo() { FirstName = "andrew", LastName = "fuller", ID = 9, Salary = 1200000, ReportsTo = 2, Title = "vice president", IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "janet", LastName = "leverling", ID = 10, Salary = 1000000, ReportsTo = 2, Title = "gm", IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "steven", LastName = "buchanan", ID = 11, Salary = 900000, ReportsTo = 2, Title = "manager", IsMissing = false });

            //Accounts
            employeeDetails.Add(new EmployeeInfo() { FirstName = "nancy", LastName = "davolio", ID = 12, Salary = 850000, ReportsTo = 3, Title = "accounts manager", IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "margaret", LastName = "peacock", ID = 13, Salary = 700000, ReportsTo = 3, Title = "accountant", IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "michael", LastName = "suyama", ID = 14, Salary = 700000, ReportsTo = 3, Title = "accountant", IsMissing = false });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "robert", LastName = "king", ID = 15, Salary = 650000, ReportsTo = 3, Title = "accountant", IsMissing = true });

            //Sales
            employeeDetails.Add(new EmployeeInfo() { FirstName = "laura", LastName = "callahan", ID = 16, Salary = 900000, ReportsTo = 4, Title = "sales manager", IsMissing = false });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "anne", LastName = "dodsworth", ID = 17, Salary = 800000, ReportsTo = 4, Title = "sales representative", IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "albert", LastName = "hellstern", ID = 18, Salary = 750000, ReportsTo = 4, Title = "sales representative", IsMissing = false });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "tim", LastName = "smith", ID = 19, Salary = 700000, ReportsTo = 4, Title = "sales representative", IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "justin", LastName = "brid", ID = 20, Salary = 700000, ReportsTo = 4, Title = "sales representative", IsMissing = false });

            //Back Office
            employeeDetails.Add(new EmployeeInfo() { FirstName = "caroline", LastName = "patterson", ID = 21, Salary = 800000, ReportsTo = 5, Title = "receptionist", IsMissing = false });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "xavier", LastName = "martin", ID = 22, Salary = 700000, ReportsTo = 5, Title = "mail clerk", IsMissing = true });

            //HR
            employeeDetails.Add(new EmployeeInfo() { FirstName = "laurent", LastName = "pereira", ID = 23, Salary = 900000, ReportsTo = 6, Title = "hr manager", IsMissing = false });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "syed", LastName = "abbas", ID = 24, Salary = 650000, ReportsTo = 6, Title = "hr assistant", IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "amy", LastName = "alberts", ID = 25, Salary = 650000, ReportsTo = 6, Title = "hr assistant", IsMissing = false });

            //Purchasing

            employeeDetails.Add(new EmployeeInfo() { FirstName = "pamela", LastName = "ansman-Wolfe", ID = 26, Salary = 600000, ReportsTo = 7, Title = "purchase manager", IsMissing = false });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "michael", LastName = "blythe", ID = 27, Salary = 550000, ReportsTo = 7, Title = "store keeper", IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "david", LastName = "campbell", ID = 28, Salary = 450000, ReportsTo = 7, Title = "store keeper", IsMissing = false });

            //Production
            employeeDetails.Add(new EmployeeInfo() { FirstName = "jillian", LastName = "carson", ID = 29, Salary = 600000, ReportsTo = 8, Title = "production manager", IsMissing = false });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "shu", LastName = "ito", ID = 30, Salary = 550000, ReportsTo = 8, Title = "production engineer", IsMissing = true });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "stephen", LastName = "jiang", ID = 31, Salary = 450000, ReportsTo = 8, Title = "production engineer", IsMissing = false });

            Employees = employeeDetails;
        }
    }
}
