using MVVMDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.ViewModels
{
    public class PeopleViewModel
    {
        public List<People> Item { get; set; }

        public PeopleViewModel()
        {
            Item = new List<People>()
            {
                new People()
                {
                Name = "I am playing MVVM stage in .NET MAUI",
                Age = 24,
                Married = true,
                BirthDate = new DateTime(2023, 08, 05),
                Weight = 60,
                Lunchtime = new TimeSpan(10, 0, 0),
                },
                new People()
                {
                Name = "I am rocking by using .NET MAUI",
                Age = 1,
                Married = false,
                BirthDate = new DateTime(1999, 12, 21),
                Weight = 65,
                Lunchtime = new TimeSpan(13, 0, 0),
                },

                new People()
                {
                Name = "I will become super good in .NET MAUI",
                Age = 2,
                Married = true,
                BirthDate = new DateTime(2023, 08, 05),
                Weight = 60,
                Lunchtime = new TimeSpan(10, 0, 0),
                },
                new People()
                {
                Name = "I am Arunachalam",
                Age = 3,
                Married = false,
                BirthDate = new DateTime(2000, 08, 10),
                Weight = 60,
                Lunchtime = new TimeSpan(10, 0, 0),
                },
                new People()
                {
                Name = "Coming soon....",
                Age = 4,
                Married = true,
                BirthDate = new DateTime(1900, 08, 05),
                Weight = 45,
                Lunchtime = new TimeSpan(21, 0, 0),
                },
        };
        }
    }
}
