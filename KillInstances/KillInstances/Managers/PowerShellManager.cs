using Microsoft.PowerShell;
using System;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace KillInstances
{
  internal class PowerShellManager
  {
    internal static void ExecutePowerShellScript(string processName)
    {
      RunspaceConfiguration runspaceConfiguration = RunspaceConfiguration.Create();

      Runspace runspace = RunspaceFactory.CreateRunspace(runspaceConfiguration);
      runspace.Open();

      using (PowerShell powerShell = PowerShell.Create())
      {
        // Add commands, parameters, etc., etc.
        powerShell.AddCommand("Set-ExecutionPolicy").AddArgument("Unrestricted").AddParameter("Scope", "CurrentUser");
        powerShell.Invoke();

        Pipeline pipeline = runspace.CreatePipeline();

        var scriptfile = $"{Directory.GetCurrentDirectory()}\\{processName}";

        //Here's how you add a new script with arguments
        Command scriptCommand = new Command(scriptfile);

        pipeline.Commands.Add(scriptCommand);

        // Execute PowerShell script
        var results = pipeline.Invoke();

        powerShell.AddCommand("Set-ExecutionPolicy").AddArgument("Undefined").AddParameter("Scope", "CurrentUser");
        powerShell.Invoke();

      }
    }
  }
}
