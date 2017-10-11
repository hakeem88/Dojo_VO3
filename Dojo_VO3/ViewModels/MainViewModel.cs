using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo_VO3.ViewModels
{
    class MainViewModel
    {
        public List<String> Shapes { get; set; } //property!!

        public MainViewModel()
        {
            Shapes = new List<string>() { "Rechteck", "Kreis" };
        }
    }
}
