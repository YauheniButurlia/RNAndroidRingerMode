using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Android.Ringer.Mode.RNAndroidRingerMode
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAndroidRingerModeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAndroidRingerModeModule"/>.
        /// </summary>
        internal RNAndroidRingerModeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAndroidRingerMode";
            }
        }
    }
}
