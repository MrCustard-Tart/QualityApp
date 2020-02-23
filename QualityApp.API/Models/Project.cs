using System.ComponentModel.DataAnnotations.Schema;

namespace QualityApp.API.Models
{
    [Table("Projects")]
    public class Project
    {      
        public int Id { get; set; }
        
        public int ProjectNumber { get; set; }

        public string Location { get; set; }

        public string Name { get; set; } 

        public string StreetNumber { get; set; }   

        public string Street { get; set; }

        public string Suburb { get; set; }

        public string PostCode { get; set; }

        public string ContractNumber { get; set; }

    }
}