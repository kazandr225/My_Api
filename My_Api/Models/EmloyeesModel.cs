using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Api.Models
{
    public class EmloyeesModel
    {
        public EmloyeesModel(Employees emp)
        {
            Id = emp.id;
            Surname = emp.Surname;
            Name = emp.Name;
            Patronymic = emp.Patronymic;
            Image = emp.image;
        }
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Image { get; set; }
    }
}