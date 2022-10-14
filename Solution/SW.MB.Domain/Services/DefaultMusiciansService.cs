﻿using Microsoft.EntityFrameworkCore;
using SW.MB.Data.Contracts.UnitsOfWork;
using SW.MB.Data.Models.Entities;
using SW.MB.Domain.Contracts.Services;
using SW.MB.Domain.Extensions;
using SW.MB.Domain.Models.Records;
using SW.MB.Domain.Services.Abstracts;

namespace SW.MB.Domain.Services {
    internal class DefaultMusiciansService : ServiceBase, IMusiciansService {
        private readonly IUnitOfWork _UnitOfWork;

        #region CONSTRUCTORS
        public DefaultMusiciansService(IUnitOfWork uow) : base() {
            _UnitOfWork = uow;
        }
        #endregion CONSTRUCTORS

        public IEnumerable<MusicianRecord> GetAll() {
            return _UnitOfWork.Musicians.Include(x => x.Mandators).Select(x => x.ToRecord());
        }

        public void UpdateRange(params MusicianRecord[] records) {
            foreach (MusicianRecord record in records) {
                if (_UnitOfWork.Musicians.SingleOrDefault(x => x.ID == record.ID) is MusicianEntity entity) {
                    SetAllProperties(entity, record.ToEntity());
                } else {
                    _UnitOfWork.Musicians.Add(record.ToEntity());
                }
            }

            _UnitOfWork.SaveChangesAsync();
        }
    }
}
