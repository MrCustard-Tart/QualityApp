using System.ComponentModel.DataAnnotations.Schema;

namespace QualityApp.API.Models
{
    [Table("Clients")]
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Representative { get; set; }

        public string Number { get; set; }

        public string Email { get; set; }

        public string Abn { get; set; }
 
        public string StreetNumber { get; set; }   

        public string Street { get; set; }

        public string Suburb { get; set; }

        public string PostCode { get; set; }
    }
}