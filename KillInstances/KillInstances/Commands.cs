using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillInstances
{
  public static class Commands
  {
    public static void StartCommand(List<System.Windows.Forms.Keys> keys)
    {
      CreateCommand(keys);
      ExecuteCommand(keys);
    }

    private static void CreateCommand(List<System.Windows.Forms.Keys> keys)
    {

    }

    private static void ExecuteCommand(List<System.Windows.Forms.Keys> keys)
    {
      // Generalize creation of executing object and wrapping all calls in an invoke()
    }
  }
}
