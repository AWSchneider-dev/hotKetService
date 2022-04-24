using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillInstances
{
  internal class Keyd
  {
      private bool justUpdated { get; set; } = false;
      private long? createdTime { get; set; }
      private long? lastTimeUpdated { get; set; }
      private bool empty { get; set; } = true;
      public List<Keys> keyd { get => keyd; set => PressedKey(value); }
      public bool IsEmpty { get => empty; set => empty = value; }

      private void PressedKey(List<Keys> value)
      {
        if(ValidateKey(value)) AddValue(value);
      }

      private void AddValue(List<Keys> value)
      {
        keyd = value;
        empty = false;
      }

      private bool ValidateKey(List<Keys> value)
      {
        bool result = false;
        if (IsEmpty) Default();
        else if (TimeValid(createdTime, lastTimeUpdated)) result = true;
        return result;
      }

      private bool TimeValid(long? createdTime, long? lastTimeUpdated)
      {
        bool result = false;

        if (createdTime.Equals(null) && lastTimeUpdated.Equals(null)) CreateTime(DateTimeOffset.Now.ToUnixTimeMilliseconds());
        if(!createdTime.Equals(null) && lastTimeUpdated.Equals(null)) UpdateTime(DateTimeOffset.Now.ToUnixTimeMilliseconds());
        if (!createdTime.Equals(null) && !lastTimeUpdated.Equals(null) && MeetsTimeRequirements(lastTimeUpdated < 0 ? (lastTimeUpdated - createdTime) : 0)) result = true;
        return result;
      }

      private bool MeetsTimeRequirements(long? v)
      {
        bool result = false;
        if (v <= 2500) result = true;
        if (v >= 2500) Default();
        return result;
      }

      private void CreateTime(long v)
      {
        createdTime = v;
        justUpdated = true;
      }

      private void UpdateTime(long v)
      {
        if (!justUpdated) lastTimeUpdated = v;
        else justUpdated = false;
      }

      private void Default()
      {
        keyd.Clear();
        createdTime = null;
        lastTimeUpdated = null;
        empty = true;
      }
  }
}
