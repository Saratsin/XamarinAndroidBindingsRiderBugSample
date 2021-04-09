using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Sample.Androidlibrary;

namespace SampleApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var implementor = new StateProviderImplementor();
            var state = implementor.State;
            var statePropertyName = nameof(StateProvider.State);
            Console.WriteLine($"{statePropertyName}: {state}");
        }

        class StateProviderImplementor : StateProvider
        {
            // NOTE If you'll comment this override, Intellisense will say that we have no errors.
            // But compilation will tell you the opposite
            private StateFlag _state = StateFlag.Superposition;
            public override StateFlag State
            {
                get => _state;
                set => _state = value;
            }
        }
    }
}
