using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using Tsystem.Models;

namespace Tsystem.Models
{
    public class SubmitRepository : ISubmitRepository
    {
        long master_id = 1000;
        Dictionary<long, List<Employee>> employee = new Dictionary<long, List<Employee>>();
        private List<Submit> submit_pto = new List<Submit>();
        private List<Submit> submit_sick = new List<Submit>();

        public SubmitRepository()
        {
            Add_employee(new Employee { id = master_id, Firstname = "Bravo", Lastname = "Smith", pto_hours = 6,sick_hours = 48 });
            Add(new Submit { id = master_id, Firstname = "Bravo", Lastname = "Smith", begindate = "2023-03-01 09:30", enddate = "2023-03-02 17:30", hours = 1, pto = true, sick = false, message = "vocation" });
            Add(new Submit { id = master_id, Firstname = "Bravo", Lastname = "Smith", begindate = "2023-03-02 09:30", enddate = "2023-03-03 17:30", hours = 1, pto = false, sick = true, message = "vocation" });
        }

        public IEnumerable<Employee> GetAll_employee()
        {
            List<Employee> result = new List<Employee>();
            foreach (List<Employee> e in employee.Values)
            {
                result.AddRange(e);
            }
            return result;
        }

        public IEnumerable<Submit> GetAll_pto()
        {
            return submit_pto;
        }

        public IEnumerable<Submit> GetAll_sick()
        {
            return submit_sick;
        }

        public IEnumerable<Submit> GetAll()
        {
            var result = submit_sick.Concat(submit_pto);
            return result;
        }

        public Submit Add(Submit item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            if (employee.ContainsKey(item.id))
            {
                Console.WriteLine("FOUND_EMPLOYEE");

                foreach (var emp in employee[item.id])
                {
                    if(item.sick == true && emp.sick_hours >= item.hours)
                    {
                        emp.sick_hours -= item.hours;
                        submit_sick.Add(item);
                    }
                    else if(item.pto == true && emp.pto_hours >= item.hours)
                    {
                        emp.pto_hours -= item.hours;
                        submit_pto.Add(item);
                    }
                    else
                    {
                        throw new ArgumentException("Insufficent hours");
                    }
                }
            }
            else
            {   
                throw new ArgumentException("Employee ID not found");
            }
            return item;
        }

        public Employee Add_employee(Employee person)
        {
            if (person == null)
            {
                throw new ArgumentNullException("person");
            }
            List<Employee> temp = new List<Employee>();
            temp.Add(person);

            if (employee.ContainsKey(person.id))
            {
                Console.WriteLine("UPDATED");
                temp.Add(person);
                employee[person.id] = temp;
            }
            else
            {
                Console.WriteLine("NOT FOUND");
                master_id += 1;
                person.id = master_id;
                employee.Add(person.id, temp);

            }

            return person;
        }
    }
}