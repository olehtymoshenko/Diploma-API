﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BL.Models.DataForFiles
{
    public class ScientistModel
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public ICollection<DegreeModel> Degrees { get; set; } = new List<DegreeModel>();
    }
}
