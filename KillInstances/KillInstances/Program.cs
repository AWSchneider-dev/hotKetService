using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillInstances
{
    class Program
    {
        static void Main(string[] args)
        {
          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);

          var json = Newtonsoft.Json.JsonConvert.SerializeObject(new HotKey());

          LowLevelKeyBoardHook kbh = new LowLevelKeyBoardHook();
          KeyPressPowerShellEventHandler keyPressHanlder = new KeyPressPowerShellEventHandler();
          kbh.OnKeyPressed += keyPressHanlder.kbh_OnKeyPressed;
          kbh.OnKeyUnpressed += keyPressHanlder.kbh_OnKeyUnPressed;
          kbh.HookKeyboard();

          Application.Run();

          kbh.UnHookKeyboard();
        }
    }
}
