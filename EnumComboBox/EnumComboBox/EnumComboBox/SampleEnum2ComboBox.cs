﻿using System;

namespace EnumComboBox
{
  public class SampleEnum2ComboBox : EnumComboBox<SampleEnum2>
  {
    private string[] m_nameArray
      = { "1: 選択肢-B1" , "2: 選択肢-B2" , "3: 選択肢-B3" };

    protected override string GetName(SampleEnum2 value)
    {
      return Enum.IsDefined(typeof(SampleEnum2), value)
                ? m_nameArray[(int)value] : null;
    }
  }
}
