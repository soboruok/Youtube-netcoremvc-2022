using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class ApplicationUserEditModel : ApplicationUserViewModel
    {
        public int Id { get; set; }
        public string ExistingCV { get; set; }
    }
}
