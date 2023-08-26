using MVVMDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.ViewModels
{
    public class PersonViewModel
    {
        private Person _person;

        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }

        public PersonViewModel()
        {
            Person = new Person()
            {
                Name = "I am playing MVVM stage in .NET MAUI",
                Age = 24,
                Married = false,
                BirthDate = new DateTime(2000, 08, 05),
                Weight = 60,
                Lunchtime = new TimeSpan(10, 0, 0),
            };
        }
    }
}
