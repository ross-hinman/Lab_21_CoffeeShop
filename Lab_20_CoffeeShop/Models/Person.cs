using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_20_CoffeeShop.Models
{
    public class PersonViewModel
    {
        [Required]
        [MinLength(2,ErrorMessage ="Must be more than 2 letters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2,ErrorMessage ="Must be more than 2 letters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Not a valid Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage ="Not a valid phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Favorite Coffee")]
        public string FavCoffee { get; set; }

        [Required]
        [MinLength(6, ErrorMessage ="Must be more than 6 characters")]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage ="Does not match password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        

    }
}