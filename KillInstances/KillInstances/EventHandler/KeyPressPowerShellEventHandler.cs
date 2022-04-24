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
      // Reset key comobonations after ever 1500 milliseconds
      if ((DateTimeOffset.Now.ToUnixTimeMilliseconds() - _keyTimerLastKeyPress) > 2500) KeyPress.ResetKeys();
      _keyTimerLastKeyPress = DateTimeOffset.Now.ToUnixTimeMilliseconds();

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

      KeyPress.SetKeyPress(true, e);

      CheckKeyCombo();
    }

    public void kbh_OnKeyUnPressed(object sender, Keys e)
    {
      KeyPress.SetKeyPress(false, e);

      CheckKeyCombo();

      //if (KeyPress.ControlKeysHandler.CheckControlKeyPressed(e, _leftOrRightAgnostic, false))
      //{

      //}

      //if (KeyPress.LetterHandler.CheckLetterPress(e, false))
      //{
      //  // TODO: Allow Words
      //}

      //if (KeyPress.DigitHandler.CheckDigitPress(e, false))
      //{
      //  // TODO: 
      //}

      //if (KeyPress.FKeyHandler.CheckFKeyPress(e, false))
      //{
      //  // TODO:
      //}
    }

    // UseKeyCombo to look up a batch of possible options from .JSON
    // Have a JSON Object that represents which letters pressed, in which sequence
    // Then which application to execute


    // Make this more general have a check outside of this class if it should call the powershell manager 
    private void CheckKeyCombo()
    {
      if (_activeHotKeys.keys.Contains(_currentActiveKeyPresses.keyd))
      {
        Commands.StartCommand(_activeHotKeys.keys.Find(x => x == _currentActiveKeyPresses.keyd));
        KeyPress.ResetKeys();
      }
    }
  }
}
