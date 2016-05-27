using Android.App;
using Android.OS;

namespace Ninja.Droid.Views
{
    [Activity]
    public class PetView : BaseView
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PetView);
        }
    }
}