using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillInstances
{
  public class Commands
  {
    public void StartCommand(object keys)
    {
      CreateCommand(keys);
      ExecuteCommand(keys);
    }

    private void CreateCommand(object keys)
    {

    }

    private void ExecuteCommand(object keys)
    {
      // Generalize creation of executing object and wrapping all calls in an invoke()
    }
  }
}
