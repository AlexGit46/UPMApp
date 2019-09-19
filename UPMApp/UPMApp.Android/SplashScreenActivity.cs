using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;

namespace UPMApp.Droid
{
    [Activity(Label = "SplashScreenActivity", Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashScreenActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        async void SimulateStartup()
        {
            await Task.Delay(2000); 
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}