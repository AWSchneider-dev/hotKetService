using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillInstances
{
  class KeyPressPowerShellEventHandler
  {

    private long _keyTimerLastKeyPress { get; set; }
    private bool _leftOrRightAgnostic { get; set; } = true;
    private Keyd _currentActiveKeyPresses { get; set; } = null;
    private HotKey _activeHotKeys { get; set; } = null;
    public void kbh_OnKeyPressed(object sender, Keys e)
    {
      CheckReset();
      #region future key specific events
      //if (KeyPress.ControlKeysHandler.CheckControlKeyPressed(e, _leftOrRightAgnostic, true))
      //{

      //}

      //if (KeyPress.LetterHandler.CheckLetterPress(e, true))
      //{
      //  // TODO: Allow Words
      //}

      //if (KeyPress.DigitHandler.CheckDigitPress(e, true))
      //{
      //  // TODO: 
      //}

      //if (KeyPress.FKeyHandler.CheckFKeyPress(e, true))
      //{
      //  // TODO:
      //}
      #endregion
      KeyPress.SetKeyPress(true, e);
      CheckKeyCombo();
    }

    public void kbh_OnKeyUnPressed(object sender, Keys e)
    {
      CheckReset();
      KeyPress.SetKeyPress(false, e);
      CheckKeyCombo();
    }

    private void CheckReset()
    {
      // Reset key comobonations after ever 2500 milliseconds
      if ((DateTimeOffset.Now.ToUnixTimeMilliseconds() - _keyTimerLastKeyPress) > 2500) KeyPress.ResetKeys();
      _keyTimerLastKeyPress = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    }

    private void CheckKeyCombo()
    {
      var matches = KeyPress.HotKey.Where(x => x.keys == KeyPress.Keyd.keyd);
      if (!matches.Equals(null)) new Commands().StartCommand(matches.FirstOrDefault());
    }
  }
}
