using CrmSample.BusinessLayer.Abstract;
using CrmSample.DataAccessLayer.Abstract;
using CrmSample.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmSample.BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void TChangeEmployeeStatusToFalse(int id)
        {
            _employeeDal.ChangeEmployeeStatusToFalse(id);
        }

        public void TChangeEmployeeStatusToTrue(int id)
        {
            _employeeDal.ChangeEmployeeStatusToTrue(id);
        }

        public void TDelete(Employee t)
        {
            _employeeDal.Delete(t);
        }

        public Employee TGetById(int id)
        {
           return _employeeDal.GetById(id);
        }

        public List<Employee> TGetEmployeeByCategory()
        {
            return _employeeDal.GetEmployeesByCategory();
        }

        public List<Employee> TGetList()
        {
           return _employeeDal.GetList();
        }

        public void TInsert(Employee t)
        {
            _employeeDal.Insert(t); 
        }

        public void TUpdate(Employee t)
        {
            _employeeDal.Update(t);

        }
    }
}
