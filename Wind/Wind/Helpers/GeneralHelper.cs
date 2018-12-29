using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Helpers
{
    public static class GeneralHelper
    {   
        public static void Speak(string text)
        {
            Xamarin.Forms.DependencyService.Get<ITextSpeecher>().Speak(text);
        }

        public static DeviceOrientations GetOrientation()
        {
            var orientation = Xamarin.Forms.DependencyService.Get<IDeviceOrientation>().GetOrientation();

            return orientation;
        }

        public static string GetLabel()
        {
            string label = Xamarin.Forms.DependencyService.Get<IPlatformLabel>().GetLabel();

            return label;
        }

        public static string GetLabel(string additionalLabel)
        {
            string label = Xamarin.Forms.DependencyService.Get<IPlatformLabel>().GetLabel(additionalLabel);

            return label;
        }

        public static string GetLabel(string additionalLabel, bool addVersion)
        {
            string label = Xamarin.Forms.DependencyService.Get<IPlatformLabel>().GetLabel(additionalLabel, addVersion);

            return label;
        }
    }
}
