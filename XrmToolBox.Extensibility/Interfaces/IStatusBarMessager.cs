﻿using System;
using XrmToolBox.Extensibility.Args;

namespace XrmToolBox.Extensibility.Interfaces
{
    /// <summary>
    /// This interface allows to send message or progress to main application
    /// to display progress data in the status bar
    /// </summary>
    public interface IStatusBarMessager
    {
        event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;
    }
}