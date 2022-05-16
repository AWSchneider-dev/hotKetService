using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillInstances
{
  public class Commands
  {
    public void StartCommand(HotKey keys)
    {
      CreateCommand(keys);
      ExecuteCommand(keys);
    }

    private void CreateCommand(HotKey keys)
    {

    }

    private void ExecuteCommand(HotKey keys)
    {
      // HotKey JSON
      // {"enumAction":null,"keys":null,"hotKeyName":null,"context":null}


      //if(keys.Action. = HotKey.Action.ExecLocalPwsh)
      //{

      //}
    }
  }
}
