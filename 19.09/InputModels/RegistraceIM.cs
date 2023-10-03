using System.ComponentModel.DataAnnotations;

namespace _19._09.InputModels
{
    public class RegistraceIM
    {
        [Display(Name = "First Name")]
        public string Name { get; set; }
        [Required]
        [MinLength(1, ErrorMessage="Min length is one character")]
        public string surname {  get; set; }
        [Display(Name = "Shoesize")]
        [Range(14,50)]
        public int Shoesize {  get; set; }
        [EmailAddress]
        [Display(Name = "Email Adress")]
        public string Email {  get; set; }
        public bool IsAdult { get; set; }
        [Display(Name = "pohlaví")]
        public Gender Gender { get; set; }
    }
}
