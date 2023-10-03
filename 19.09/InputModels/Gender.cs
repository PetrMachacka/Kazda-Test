using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace _19._09.InputModels
{
    public enum Gender
    {
        [Display(Name = "muž")]
        Man = 0,
        [Display(Name = "Žena")]
        Woman = 1,
        [Display(Name = "Cosi")]
        Cosi = 0
    }
}
