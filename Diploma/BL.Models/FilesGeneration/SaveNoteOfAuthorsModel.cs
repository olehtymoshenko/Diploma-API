﻿using System;
using System.Collections.Generic;


namespace BL.Models.FilesGeneration
{
    public class SaveNoteOfAuthorsModel
    {
        public List<Author> Authors { get; set; }

        public string PublishingNameWithItsStatics { get; set; }

        public string PublishingHouse { get; set; }

        public DateTime PublishingDate { get; set; }

        public string FullNameOfChiefOfUniversityDepartment { get; set; }
    }
}