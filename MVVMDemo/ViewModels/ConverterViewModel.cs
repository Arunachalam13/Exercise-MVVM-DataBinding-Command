using MVVMDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.ViewModels
{
    public class ConverterViewModel
    {
        public Data Data { get; set; }

        public ConverterViewModel()
        {
            Data = new Data
            {
                Goal = "Yes"
            };
        }
    }
}
