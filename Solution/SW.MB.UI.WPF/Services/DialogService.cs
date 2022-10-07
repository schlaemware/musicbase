﻿using System.Windows;

namespace SW.MB.UI.WPF.Services {
  internal static class DialogService {
    public static void ShowUnhandledExceptionDialog(bool isTerminating) {
      string caption = Properties.Resources.DialogUnhandledExceptionCaption;
      string message = isTerminating
        ? Properties.Resources.DialogUnhandledExceptionTerminatingMessage
        : Properties.Resources.DialogUnhandledExceptionMessage;

      MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
    }
  }
}