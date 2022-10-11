﻿using Microsoft.Extensions.DependencyInjection;
using SW.MB.Data.Contracts;
using SW.MB.Domain.Contracts;
using SW.MB.Domain.Extensions;
using SW.MB.Domain.Implementations.Abstracts;
using SW.MB.Domain.Models.Records;

namespace SW.MB.Domain.Implementations {
  internal class DefaultMandatorsService : ServiceBase, IMandatorsService {
    #region CONSTRUCTORS
    public DefaultMandatorsService(IServiceProvider serviceProvider) : base(serviceProvider) {
      // empty...
    }
    #endregion CONSTRUCTORS

    public IEnumerable<MandatorRecord> GetAll() {
      IUnitOfWork uow = ServiceProvider.GetRequiredService<IUnitOfWork>();
      return uow.Mandators.Select(x => x.ToRecord());
    }
  }
}
