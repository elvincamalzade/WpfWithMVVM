using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWithMVVM.Models;

namespace WpfWithMVVM.Repo
{
    public class FakeRepo
    {
        public List<Printer> GetAll()
        {
            return new List<Printer> {
            new Printer
            {
                Color="Red",
                Model="R100",
                Vendor="Canon"
            },
            new Printer
             {
                Color="Blue",
                Model="LLL100",
                Vendor="HP"
            },
            new Printer
            {
                Color="Sky",
                Model="M100",
                Vendor="Epson"
            },
            new Printer
            {
                Color="Indigo",
                Model="C202",
                Vendor="Varta"
            }
            };
        }
    }
}
