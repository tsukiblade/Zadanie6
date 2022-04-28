using System.ComponentModel.DataAnnotations;

namespace Zadanie6
{
    public enum RegionEnum
    {
        [Display(Name = "Białystok")]
        Bialystok = 1,
        Warszawa,
        [Display(Name = "Poznań")]
        Poznan,
        [Display(Name = "Kraków")]
        Krakow
    }
}
