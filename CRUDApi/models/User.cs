using System.ComponentModel.DataAnnotations;

namespace CRUDApi.models
{
    public class User
    {
        [Key]
        public int userId {get; set;}
        public string name {get; set;}
        public string lastName {get; set;}
        public string userEmail {get; set;}
        public DateTime dateNasc {get; set;}
        public int educationLevel {get; set;}
    }
}