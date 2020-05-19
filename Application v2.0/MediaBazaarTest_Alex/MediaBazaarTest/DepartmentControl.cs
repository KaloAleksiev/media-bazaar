using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
    public class DepartmentControl
    {
        private DeparmentDataControl ddc;
        private List<DepartmentClass> departments;

        public DepartmentControl()
        {
            departments = new List<DepartmentClass>();
            ddc = new DeparmentDataControl();
            foreach (DepartmentClass d in ddc.GetAllDepartments())
            {
                departments.Add(d);
            }
        }

        public void AddDepartment(string name)
        {
            DepartmentClass dep = new DepartmentClass(ddc.GetMaxId(), name);
            ddc.AddDepartment(dep);
            departments.Add(dep);
        }

        public DepartmentClass GetDepartmentByID(int id)
        {
            foreach(DepartmentClass d in departments)
            {
                if(d.Id == id)
                {
                    return d;
                }
            }
            return null;
        }

        public DepartmentClass GetDepartmentByName(string name)
        {
            foreach (DepartmentClass d in departments)
            {
                if (d.Name == name)
                {
                    return d;
                }
            }
            return null;
        }

        public List<DepartmentClass> GetDepartments()
        {
            return this.departments;
        }
    }
}
