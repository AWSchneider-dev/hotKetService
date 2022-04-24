using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillInstances
{
  static class KeyPress
  {
    #region properties
    private static bool win_Key = false;
    private static bool Lwin_Key = false;
    private static bool Rwin_Key = false;
    private static bool menu_Key = false;
    private static bool esc_Key = false;
    private static bool f1_Key = false;
    private static bool f2_Key = false;
    private static bool f3_Key = false;
    private static bool f4_Key = false;
    private static bool f5_Key = false;
    private static bool f6_Key = false;
    private static bool f7_Key = false;
    private static bool f8_Key = false;
    private static bool f9_Key = false;
    private static bool f10_Key = false;
    private static bool f11_Key = false;
    private static bool f12_Key = false;
    private static bool f13_Key = false;
    private static bool f14_Key = false;
    private static bool f15_Key = false;
    private static bool f16_Key = false;
    private static bool f17_Key = false;
    private static bool f18_Key = false;
    private static bool f19_Key = false;
    private static bool f20_Key = false;
    private static bool f21_Key = false;
    private static bool f22_Key = false;
    private static bool f23_Key = false;
    private static bool f24_Key = false;
    private static bool tab_Key = false;
    private static bool capsLock_Key = false;
    private static bool shift_Key = false;
    private static bool ctrl_Key = false;
    private static bool Lctrl_Key = false;
    private static bool Rctrl_Key = false;
    private static bool fn_Key = false;
    private static bool alt_Key = false;
    private static bool Lalt_Key = false;
    private static bool Ralt_Key = false;
    private static bool spaceBar_Key = false;
    private static bool arrowUp_Key = false;
    private static bool arrowLeft_Key = false;
    private static bool arrowRight_Key = false;
    private static bool arrowDown_Key = false;
    private static bool backspace_Key = false;
    private static bool delete_Key = false;
    private static bool enter_Key = false;
    private static bool prtScreen_Key = false;
    private static bool scrollLock_Key = false;
    private static bool pause_Key = false;
    private static bool break_Key = false;
    private static bool insert_Key = false;
    private static bool home_Key = false;
    private static bool pgUp_Key = false;
    private static bool pgDwn_Key = false;
    private static bool end_Key = false;
    private static bool numLock_Key = false;
    private static bool backQuote_Key = false;
    private static bool letterQ_Key = false;
    private static bool letterW_Key = false;
    private static bool letterE_Key = false;
    private static bool letterR_Key = false;
    private static bool letterT_Key = false;
    private static bool letterY_Key = false;
    private static bool letterU_Key = false;
    private static bool letterI_Key = false;
    private static bool letterO_Key = false;
    private static bool letterP_Key = false;
    private static bool letterA_Key = false;
    private static bool letterS_Key = false;
    private static bool letterD_Key = false;
    private static bool letterF_Key = false;
    private static bool letterG_Key = false;
    private static bool letterH_Key = false;
    private static bool letterJ_Key = false;
    private static bool letterK_Key = false;
    private static bool letterL_Key = false;
    private static bool letterZ_Key = false;
    private static bool letterX_Key = false;
    private static bool letterC_Key = false;
    private static bool letterV_Key = false;
    private static bool letterB_Key = false;
    private static bool letterN_Key = false;
    private static bool letterM_Key = false;
    private static bool number0_Key = false;
    private static bool number1_Key = false;
    private static bool number2_Key = false;
    private static bool number3_Key = false;
    private static bool number4_Key = false;
    private static bool number5_Key = false;
    private static bool number6_Key = false;
    private static bool number7_Key = false;
    private static bool number8_Key = false;
    private static bool number9_Key = false;
    private static bool minus_Key = false;
    private static bool equals_Key = false;
    private static bool openBracket_Key = false;
    private static bool closeBracket_Key = false;
    private static bool backSlash_Key = false;
    private static bool semiColon_Key = false;
    private static bool apostrophe_Key = false;
    private static bool comma_Key = false;
    private static bool period_Key = false;
    private static bool forwardSlash_Key = false;

    private static int keyPressCount = 0;
    public static bool Win_KeyPressed { get => win_Key; set => win_Key = value; }
    public static bool LWin_KeyPressed { get => Lwin_Key; set => Lwin_Key = value; }
    public static bool RWin_KeyPressed { get => Rwin_Key; set => Rwin_Key = value; }
    public static bool Menu_KeyPressed { get => menu_Key; set => menu_Key = value; }
    public static bool Esc_KeyPressed { get => esc_Key; set => esc_Key = value; }
    public static bool F1_KeyPressed { get => f1_Key; set => f1_Key = value; }
    public static bool F2_KeyPressed { get => f2_Key; set => f2_Key = value; }
    public static bool F3_KeyPressed { get => f3_Key; set => f3_Key = value; }
    public static bool F4_KeyPressed { get => f4_Key; set => f4_Key = value; }
    public static bool F5_KeyPressed { get => f5_Key; set => f5_Key = value; }
    public static bool F6_KeyPressed { get => f6_Key; set => f6_Key = value; }
    public static bool F7_KeyPressed { get => f7_Key; set => f7_Key = value; }
    public static bool F8_KeyPressed { get => f8_Key; set => f8_Key = value; }
    public static bool F9_KeyPressed { get => f9_Key; set => f9_Key = value; }
    public static bool F10_KeyPressed { get => f10_Key; set => f10_Key = value; }
    public static bool F11_KeyPressed { get => f11_Key; set => f11_Key = value; }
    public static bool F12_KeyPressed { get => f12_Key; set => f12_Key = value; }
    public static bool F13_KeyPressed { get => f13_Key; set => f13_Key = value; }
    public static bool F14_KeyPressed { get => f14_Key; set => f14_Key = value; }
    public static bool F15_KeyPressed { get => f15_Key; set => f15_Key = value; }
    public static bool F16_KeyPressed { get => f16_Key; set => f16_Key = value; }
    public static bool F17_KeyPressed { get => f17_Key; set => f17_Key = value; }
    public static bool F18_KeyPressed { get => f18_Key; set => f18_Key = value; }
    public static bool F19_KeyPressed { get => f19_Key; set => f19_Key = value; }
    public static bool F20_KeyPressed { get => f20_Key; set => f20_Key = value; }
    public static bool F21_KeyPressed { get => f21_Key; set => f21_Key = value; }
    public static bool F22_KeyPressed { get => f22_Key; set => f22_Key = value; }
    public static bool F23_KeyPressed { get => f23_Key; set => f23_Key = value; }
    public static bool F24_KeyPressed { get => f24_Key; set => f24_Key = value; }
    public static bool Tab_KeyPressed { get => tab_Key; set => tab_Key = value; }
    public static bool CapsLock_KeyPressed { get => capsLock_Key; set => capsLock_Key = value; }
    public static bool Shift_KeyPressed { get => shift_Key; set => shift_Key = value; }
    public static bool LCtrl_KeyPressed { get => Lctrl_Key; set => Lctrl_Key = value; }
    public static bool RCtrl_KeyPressed { get => Rctrl_Key; set => Rctrl_Key = value; }
    public static bool Ctrl_KeyPressed { get => ctrl_Key; set => ctrl_Key = value; }
    public static bool Fn_KeyPressed { get => fn_Key; set => fn_Key = value; }
    public static bool Alt_KeyPressed { get => alt_Key; set => alt_Key = value; }
    public static bool LAlt_KeyPressed { get => Lalt_Key; set => Lalt_Key = value; }
    public static bool RAlt_KeyPressed { get => Ralt_Key; set => Ralt_Key = value; }
    public static bool SpaceBar_KeyPressed { get => spaceBar_Key; set => spaceBar_Key = value; }
    public static bool ArrowUp_KeyPressed { get => arrowUp_Key; set => arrowUp_Key = value; }
    public static bool ArrowLeft_KeyPressed { get => arrowLeft_Key; set => arrowLeft_Key = value; }
    public static bool ArrowRight_KeyPressed { get => arrowRight_Key; set => arrowRight_Key = value; }
    public static bool ArrowDown_KeyPressed { get => arrowDown_Key; set => arrowDown_Key = value; }
    public static bool Backspace_KeyPressed { get => backspace_Key; set => backspace_Key = value; }
    public static bool Delete_KeyPressed { get => delete_Key; set => delete_Key = value; }
    public static bool Enter_KeyPressed { get => enter_Key; set => enter_Key = value; }
    public static bool PrtScreen_KeyPressed { get => prtScreen_Key; set => prtScreen_Key = value; }
    public static bool ScrollLock_KeyPressed { get => scrollLock_Key; set => scrollLock_Key = value; }
    public static bool Pause_KeyPressed { get => pause_Key; set => pause_Key = value; }
    public static bool Break_KeyPressed { get => break_Key; set => break_Key = value; }
    public static bool Insert_KeyPressed { get => insert_Key; set => insert_Key = value; }
    public static bool Home_KeyPressed { get => home_Key; set => home_Key = value; }
    public static bool PgUp_KeyPressed { get => pgUp_Key; set => pgUp_Key = value; }
    public static bool PgDwn_KeyPressed { get => pgDwn_Key; set => pgDwn_Key = value; }
    public static bool End_KeyPressed { get => end_Key; set => end_Key = value; }
    public static bool NumLock_KeyPressed { get => numLock_Key; set => numLock_Key = value; }
    public static bool BackQuote_KeyPressed { get => backQuote_Key; set => backQuote_Key = value; }
    public static bool LetterQ_KeyPressed { get => letterQ_Key; set => letterQ_Key = value; }
    public static bool LetterW_KeyPressed { get => letterW_Key; set => letterW_Key = value; }
    public static bool LetterE_KeyPressed { get => letterE_Key; set => letterE_Key = value; }
    public static bool LetterR_KeyPressed { get => letterR_Key; set => letterR_Key = value; }
    public static bool LetterT_KeyPressed { get => letterT_Key; set => letterT_Key = value; }
    public static bool LetterY_KeyPressed { get => letterY_Key; set => letterY_Key = value; }
    public static bool LetterU_KeyPressed { get => letterU_Key; set => letterU_Key = value; }
    public static bool LetterI_KeyPressed { get => letterI_Key; set => letterI_Key = value; }
    public static bool LetterO_KeyPressed { get => letterO_Key; set => letterO_Key = value; }
    public static bool LetterP_KeyPressed { get => letterP_Key; set => letterP_Key = value; }
    public static bool LetterA_KeyPressed { get => letterA_Key; set => letterA_Key = value; }
    public static bool LetterS_KeyPressed { get => letterS_Key; set => letterS_Key = value; }
    public static bool LetterD_KeyPressed { get => letterD_Key; set => letterD_Key = value; }
    public static bool LetterF_KeyPressed { get => letterF_Key; set => letterF_Key = value; }
    public static bool LetterG_KeyPressed { get => letterG_Key; set => letterG_Key = value; }
    public static bool LetterH_KeyPressed { get => letterH_Key; set => letterH_Key = value; }
    public static bool LetterJ_KeyPressed { get => letterJ_Key; set => letterJ_Key = value; }
    public static bool LetterK_KeyPressed { get => letterK_Key; set => letterK_Key = value; }
    public static bool LetterL_KeyPressed { get => letterL_Key; set => letterL_Key = value; }
    public static bool LetterZ_KeyPressed { get => letterZ_Key; set => letterZ_Key = value; }
    public static bool LetterX_KeyPressed { get => letterX_Key; set => letterX_Key = value; }
    public static bool LetterC_KeyPressed { get => letterC_Key; set => letterC_Key = value; }
    public static bool LetterV_KeyPressed { get => letterV_Key; set => letterV_Key = value; }
    public static bool LetterB_KeyPressed { get => letterB_Key; set => letterB_Key = value; }
    public static bool LetterN_KeyPressed { get => letterN_Key; set => letterN_Key = value; }
    public static bool LetterM_KeyPressed { get => letterM_Key; set => letterM_Key = value; }
    public static bool Number0_KeyPressed { get => number0_Key; set => number0_Key = value; }
    public static bool Number1_KeyPressed { get => number1_Key; set => number1_Key = value; }
    public static bool Number2_KeyPressed { get => number2_Key; set => number2_Key = value; }
    public static bool Number3_KeyPressed { get => number3_Key; set => number3_Key = value; }
    public static bool Number4_KeyPressed { get => number4_Key; set => number4_Key = value; }
    public static bool Number5_KeyPressed { get => number5_Key; set => number5_Key = value; }
    public static bool Number6_KeyPressed { get => number6_Key; set => number6_Key = value; }
    public static bool Number7_KeyPressed { get => number7_Key; set => number7_Key = value; }
    public static bool Number8_KeyPressed { get => number8_Key; set => number8_Key = value; }
    public static bool Number9_KeyPressed { get => number9_Key; set => number9_Key = value; }
    public static bool Minus_KeyPressed { get => minus_Key; set => minus_Key = value; }
    public static bool Equals_KeyPressed { get => equals_Key; set => equals_Key = value; }
    public static bool OpenBracket_KeyPressed { get => openBracket_Key; set => openBracket_Key = value; }
    public static bool CloseBracket_KeyPressed { get => closeBracket_Key; set => closeBracket_Key = value; }
    public static bool BackSlash_KeyPressed { get => backSlash_Key; set => backSlash_Key = value; }
    public static bool SemiColon_KeyPressed { get => semiColon_Key; set => semiColon_Key = value; }
    public static bool Apostrophe_KeyPressed { get => apostrophe_Key; set => apostrophe_Key = value; }
    public static bool Comma_KeyPressed { get => comma_Key; set => comma_Key = value; }
    public static bool Period_KeyPressed { get => period_Key; set => period_Key = value; }
    public static bool ForwardSlash_KeyPressed { get => forwardSlash_Key; set => forwardSlash_Key = value; }
    #endregion

    private static Keyd keyd = new Keyd();
    private static List<HotKey> hotKey = new List<HotKey>();
    public static Keyd Keyd { get => keyd; set => keyd = value; }
    public static List<HotKey> HotKey { get => hotKey; set => hotKey = value; }
    public static int KeyPressCount { get => keyPressCount; set => keyPressCount = value; }
    public static void ResetKeys()
    {
      win_Key = false;
      Lwin_Key = false;
      Rwin_Key = false;
      menu_Key = false;
      esc_Key = false;
      f1_Key = false;
      f2_Key = false;
      f3_Key = false;
      f4_Key = false;
      f5_Key = false;
      f6_Key = false;
      f7_Key = false;
      f8_Key = false;
      f9_Key = false;
      f10_Key = false;
      f11_Key = false;
      f12_Key = false;
      f13_Key = false;
      f14_Key = false;
      f15_Key = false;
      f16_Key = false;
      f17_Key = false;
      f18_Key = false;
      f19_Key = false;
      f20_Key = false;
      f21_Key = false;
      f22_Key = false;
      f23_Key = false;
      f24_Key = false;
      tab_Key = false;
      capsLock_Key = false;
      shift_Key = false;
      ctrl_Key = false;
      Lctrl_Key = false;
      Rctrl_Key = false;
      fn_Key = false;
      alt_Key = false;
      Lalt_Key = false;
      Ralt_Key = false;
      spaceBar_Key = false;
      arrowUp_Key = false;
      arrowLeft_Key = false;
      arrowRight_Key = false;
      arrowDown_Key = false;
      backspace_Key = false;
      delete_Key = false;
      enter_Key = false;
      prtScreen_Key = false;
      scrollLock_Key = false;
      pause_Key = false;
      break_Key = false;
      insert_Key = false;
      home_Key = false;
      pgUp_Key = false;
      pgDwn_Key = false;
      end_Key = false;
      numLock_Key = false;
      backQuote_Key = false;
      letterQ_Key = false;
      letterW_Key = false;
      letterE_Key = false;
      letterR_Key = false;
      letterT_Key = false;
      letterY_Key = false;
      letterU_Key = false;
      letterI_Key = false;
      letterO_Key = false;
      letterP_Key = false;
      letterA_Key = false;
      letterS_Key = false;
      letterD_Key = false;
      letterF_Key = false;
      letterG_Key = false;
      letterH_Key = false;
      letterJ_Key = false;
      letterK_Key = false;
      letterL_Key = false;
      letterZ_Key = false;
      letterX_Key = false;
      letterC_Key = false;
      letterV_Key = false;
      letterB_Key = false;
      letterN_Key = false;
      letterM_Key = false;
      number0_Key = false;
      number1_Key = false;
      number2_Key = false;
      number3_Key = false;
      number4_Key = false;
      number5_Key = false;
      number6_Key = false;
      number7_Key = false;
      number8_Key = false;
      number9_Key = false;
      minus_Key = false;
      equals_Key = false;
      openBracket_Key = false;
      closeBracket_Key = false;
      backSlash_Key = false;
      semiColon_Key = false;
      apostrophe_Key = false;
      comma_Key = false;
      period_Key = false;
      forwardSlash_Key = false;

      KeyPressCount = 0;
    }

    public static void SetKeyPress(bool value, Keys e)
    {
      if (!value)
      {
        if (KeyPress.KeyPressCount < 0) KeyPress.KeyPressCount = 0;
        if (KeyPress.KeyPressCount > 0) KeyPress.KeyPressCount -= 1;
      }

      if (value)
      {
        KeyPress.KeyPressCount += 1;
        if (KeyPress.KeyPressCount > 4)
        {
          KeyPress.ResetKeys();
          KeyPress.KeyPressCount += 1;
        }
        keyd.keyd.Add(e);
      }
    }

    //public static class LetterHandler
    //{
    //  public static bool CheckLetterPress(Keys e, bool enabled)
    //  {
    //    bool result = false;

    //    char.TryParse(e.ToString(), out char letterResult);

    //    if (!letterResult.Equals(null)) result = true;

    //    //if (e == Keys.A)
    //    //{
    //    //  KeyPress.LetterA_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.B)
    //    //{
    //    //  KeyPress.LetterB_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.C)
    //    //{
    //    //  KeyPress.LetterC_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D)
    //    //{
    //    //  KeyPress.LetterD_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.E)
    //    //{
    //    //  KeyPress.LetterE_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.F)
    //    //{
    //    //  KeyPress.LetterF_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.G)
    //    //{
    //    //  KeyPress.LetterG_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.H)
    //    //{
    //    //  KeyPress.LetterE_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.I)
    //    //{
    //    //  KeyPress.LetterI_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.J)
    //    //{
    //    //  KeyPress.LetterJ_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.K)
    //    //{
    //    //  KeyPress.LetterK_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.L)
    //    //{
    //    //  KeyPress.LetterL_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.M)
    //    //{
    //    //  KeyPress.LetterM_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.N)
    //    //{
    //    //  KeyPress.LetterN_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.O)
    //    //{
    //    //  KeyPress.LetterO_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.P)
    //    //{
    //    //  KeyPress.LetterP_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.Q)
    //    //{
    //    //  KeyPress.LetterR_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.S)
    //    //{
    //    //  KeyPress.LetterS_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.T)
    //    //{
    //    //  KeyPress.LetterT_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.U)
    //    //{
    //    //  KeyPress.LetterU_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.V)
    //    //{
    //    //  KeyPress.LetterV_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.W)
    //    //{
    //    //  KeyPress.LetterW_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.X)
    //    //{
    //    //  KeyPress.LetterX_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.Y)
    //    //{
    //    //  KeyPress.LetterY_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.Z)
    //    //{
    //    //  KeyPress.LetterZ_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else
    //    //{
    //    //  result = false;
    //    //}

    //    return result;

    //  }
    //}

    //public static class DigitHandler
    //{
    //  public static bool CheckDigitPress(Keys e, bool enabled)
    //  {
    //    bool result = false;

    //    int.TryParse(e.ToString(), out int numberResult);

    //    if (!numberResult.Equals(null)) result = true;

    //    //if (e == Keys.D0)
    //    //{
    //    //  KeyPress.Number0_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D1)
    //    //{
    //    //  KeyPress.Number1_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D2)
    //    //{
    //    //  KeyPress.Number2_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D3)
    //    //{
    //    //  KeyPress.Number3_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D4)
    //    //{
    //    //  KeyPress.Number4_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D5)
    //    //{
    //    //  KeyPress.Number5_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D6)
    //    //{
    //    //  KeyPress.Number6_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D7)
    //    //{
    //    //  KeyPress.Number7_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D8)
    //    //{
    //    //  KeyPress.Number8_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else if (e == Keys.D9)
    //    //{
    //    //  KeyPress.Number9_KeyPressed = SetKeyPress(enabled, e);
    //    //}
    //    //else
    //    //{
    //    //  result = false;
    //    //}

    //    return result;

    //  }
    //}

    //public static class FKeyHandler
    //{
    //  public static bool CheckFKeyPress(Keys e, bool enabled)
    //  {

    //    bool result = true;

    //    if (e == Keys.F1)
    //    {
    //      KeyPress.F1_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F2)
    //    {
    //      KeyPress.F2_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F3)
    //    {
    //      KeyPress.F3_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F4)
    //    {
    //      KeyPress.F4_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F5)
    //    {
    //      KeyPress.F5_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F6)
    //    {
    //      KeyPress.F6_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F7)
    //    {
    //      KeyPress.F7_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F8)
    //    {
    //      KeyPress.F8_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F9)
    //    {
    //      KeyPress.F9_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F10)
    //    {
    //      KeyPress.F10_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F11)
    //    {
    //      KeyPress.F11_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F12)
    //    {
    //      KeyPress.F12_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else
    //    {
    //      result = false;
    //    }

    //    return result;

    //  }
    //}

    //public static class ControlKeysHandler
    //{
    //  public static bool CheckControlKeyPressed(Keys e, bool leftOrRightAgnostic, bool enabled)
    //  {

    //    bool result = true;

    //    if (leftOrRightAgnostic) result = AgnosticCheck(e, enabled);
    //    if (!leftOrRightAgnostic) result = NonAgnosticCheck(e, enabled);
      

    //    return result;

    //  }

    //  private static bool NonAgnosticCheck(Keys e, bool enabled)
    //  {
    //    bool result = true;

    //    if (e == Keys.LControlKey)
    //    {
    //      KeyPress.Lctrl_Key = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.Alt)
    //    {
    //      KeyPress.Alt_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.LWin || e == Keys.RWin)
    //    {
    //      KeyPress.Win_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.Shift)
    //    {
    //      KeyPress.Shift_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F6)
    //    {
    //      KeyPress.F6_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F7)
    //    {
    //      KeyPress.F7_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F8)
    //    {
    //      KeyPress.F8_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F9)
    //    {
    //      KeyPress.F9_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F10)
    //    {
    //      KeyPress.F10_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F11)
    //    {
    //      KeyPress.F11_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F12)
    //    {
    //      KeyPress.F12_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else
    //    {
    //      result = false;
    //    }

    //    return result;
    //  }

    //  private static bool AgnosticCheck(Keys e, bool enabled)
    //  {
    //    bool result = true;

    //    if (e == Keys.ControlKey)
    //    {
    //      KeyPress.ctrl_Key = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.Alt)
    //    {
    //      KeyPress.Alt_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.LWin || e == Keys.RWin)
    //    {
    //      KeyPress.Win_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.Shift)
    //    {
    //      KeyPress.Shift_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F6)
    //    {
    //      KeyPress.F6_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F7)
    //    {
    //      KeyPress.F7_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F8)
    //    {
    //      KeyPress.F8_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F9)
    //    {
    //      KeyPress.F9_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F10)
    //    {
    //      KeyPress.F10_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F11)
    //    {
    //      KeyPress.F11_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else if (e == Keys.F12)
    //    {
    //      KeyPress.F12_KeyPressed = SetKeyPress(enabled, e);
    //    }
    //    else
    //    {
    //      result = false;
    //    }

    //    return result;
    //  }
    //}
  }
}
