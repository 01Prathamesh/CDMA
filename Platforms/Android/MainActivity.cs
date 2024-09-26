using Android.App;
using Android.Content.PM;
using Android.OS;

namespace CDMA.Platforms.Android
{
    [Activity(Theme = "@style/SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation |
                                  ConfigChanges.UiMode | ConfigChanges.ScreenLayout |
                                  ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Additional initialization code can go here if needed
        }
    }
}
