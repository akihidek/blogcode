﻿using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.ViewManagement;

namespace TopMostWindow
{
  public static class LocalSettings
  {
    static IPropertySet _values
      => ApplicationData.Current.LocalSettings.Values;

    const string CompactOverlaySizeKey = "CompactOverlaySize";
    public static Size CompactOverlaySize
    {
      get
      {
        if (_values.ContainsKey(CompactOverlaySizeKey))
          return (Size)_values[CompactOverlaySizeKey];
        return default(Size);
      }
      set => _values[CompactOverlaySizeKey] = value;
    }

    const string PreviousViewModeKey = "PreviousViewMode";
    public static ApplicationViewMode PreviousViewMode
    {
      get {
        if (_values.ContainsKey(PreviousViewModeKey))
        {
          var modeString = _values[PreviousViewModeKey] as string;
          if (Enum.TryParse(modeString, out ApplicationViewMode mode))
            return mode;
        }
        return ApplicationViewMode.Default;
      }
      set => _values [PreviousViewModeKey] = value.ToString();
    }
  }
}
