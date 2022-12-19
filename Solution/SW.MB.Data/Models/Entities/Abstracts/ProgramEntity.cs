﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SW.MB.Data.Models.Entities.Abstracts {
    public abstract class ProgramEntity : Entity {
        [Column(Order = 5)]
        public MandatorEntity Mandator { get; set; }

        [Column(Order = 6, TypeName = "varchar(50)")]
        public string Name { get; set; }
    }
}
