﻿using System.ComponentModel.DataAnnotations.Schema;
using SW.MB.Data.Models.Entities.Abstracts;

namespace SW.MB.Data.Models.Entities {
  [Table("Bands")]
  public class BandEntity: Entity {
    public virtual ICollection<MusicianEntity> Musicians { get; set; } = new List<MusicianEntity>();

    public string Name { get; set; }
  }
}