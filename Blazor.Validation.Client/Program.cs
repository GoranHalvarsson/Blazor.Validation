﻿using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Blazor.Extensions.Logging;
using System;

namespace Blazor.Validation.Client
{
  public class Program
  {
    static void Main(string[] args)
    {
      var serviceProvider = new BrowserServiceProvider(services =>
      {
        // Add any custom services here
        services.AddLogging(builder => builder.AddBrowserConsole()
                .SetMinimumLevel(LogLevel.Information));
      });

      new BrowserRenderer(serviceProvider).AddComponent<App>("app");
    }
  }
}
