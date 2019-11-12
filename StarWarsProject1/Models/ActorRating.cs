﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarWarsProject1.Models
{
    public class ActorRating
    {
        [Required] //this will be the actor initials entered in by the user
        [StringLength(3, MinimumLength =2, ErrorMessage ="Must be 2-3 characters long. Try entering in their initials.")]
        [Display(Name ="Actor Initials")]
        public string ActorCode { get; set; }

        [Required] //this will be the actor first name entered by the user
        [StringLength(15, ErrorMessage ="Must be under 15 characters long.")]
        [Display(Name = "Actor First Name")]
        public string FirstName { get; set; }

        [Required] //this will be the actor last name entered by the user
        [StringLength(20, ErrorMessage = "Must be under 20 characters long.")]
        [Display(Name = "Actor Last Name")]
        public string LastName { get; set; }

        [Required] //this will be a hardcoded dropdown, similar to the Movie Review
        [Display(Name = "Actor Rating")]
        public string Rating { get; set; }

        [Required] //this will be a dynamic dropdown of the list of movies the user entered in SeenMovies
        [StringLength(50, ErrorMessage = "Must be under 50 characters long.")]
        [Display(Name = "First Star Wars Appearance")]
        public string MovieTitle { get; set; }
    }
}