using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Entities
{
    public class LocationEntity
    {
        [StringLength(10)]
        [Column("country_code")]
        public string CountryCode { get; set; }

        [StringLength(10)]
        [Column("department_code")]
        public string DepartmentCode { get; set; }

        [StringLength(10)]
        [Column("city_code")]
        public string CityCode { get; set; }


        [StringLength(100)]
        [Column("country_name")]
        public string CountryName { get; set; }

        [StringLength(100)]
        [Column("department_name")]
        public string DepartmentName { get; set; }

        [StringLength(100)]
        [Column("city_name")]
        public string CityName { get; set; }

        public LocationEntity(string countryCode, string departmentCode, string cityCode, string countryName, string departmentName, string cityName)
        {
            this.CountryCode = countryCode;
            this.DepartmentCode = departmentCode;
            this.CityCode = cityCode;
            this.CountryName = countryName;
            this.DepartmentName = departmentName;
            this.CityName = cityName;
        }
    }
}
