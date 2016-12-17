using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace ExitTest01.Droid
{
    [Activity(Label = "ExitTest01.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class SomeActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_some);
        }

        public override void OnBackPressed()
        {
            System.Environment.Exit(0);
        }
    }
}
