﻿using Microsoft.EntityFrameworkCore;
using SW.MB.Data.Models.Configurations.Abstracts;
using SW.MB.Data.Models.Entities;

namespace SW.MB.Data.Models.Configurations {
    internal class MandatorEntityEntityConfiguration : BaseEntityTypeConfiguration<MandatorEntity>, IEntityTypeConfiguration<MandatorEntity> {

    }
}
