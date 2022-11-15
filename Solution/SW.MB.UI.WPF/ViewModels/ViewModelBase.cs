﻿using System;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SW.MB.UI.WPF.ViewModels {
  public abstract class ViewModelBase: ObservableObject {
    protected readonly Dispatcher Dispatcher = Dispatcher.CurrentDispatcher;
    protected readonly IServiceProvider ServiceProvider;

    public bool IsDebug {
#if DEBUG
      get => true;
#else
      get => false;
#endif
    }

    #region CONSTRUCTORS
    public ViewModelBase(IServiceProvider serviceProvider) : base() {
      ServiceProvider = serviceProvider;
    }
    #endregion CONSTRUCTORS

    public virtual void Initialize() {
      // empty...
    }
  }
}
