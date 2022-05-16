using System.Collections.Generic;
using System.Windows.Forms;

namespace KillInstances
{
  public class HotKey
  {
    public object enumAction;
    public List<Keys> keys { get; set; }
    public string hotKeyName { get; set; }

    // Custom object or enum defining a set of possible actions
    // Open File
    // Play Sound
    // Kill Processes
    // Play localVideo
    // Open YouTube Video
    // Open url
    // exec local .exe
    // exec local .ps1
    // exec local .py

    public enum Action
    {
      OpenFile,
      PlaySound,
      KillProcess,
      KillAllBrowsers,
      PlayLocalVideo,
      OpenURL,
      ExecLocalExec,
      ExecLocalPwsh,
      ExecLocalPy
    };
    public object context { get; set; }

    public void setProgAction(Action action)
    {
      enumAction = action;
    }
    public Action GetAction()
    {
      Action result = Action.ExecLocalPwsh;
      if (!enumAction.Equals(null)) result = (Action)enumAction;

      return result;
    }
  }
}
