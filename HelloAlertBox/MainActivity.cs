using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelloAlertBox
{
    [Activity(Label = "HelloAlertBox", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            //Just Got rid of the default template.Nothing much.
            //We'll hook our button to do stuff!!!

            var myButton = FindViewById<Button>(Resource.Id.buttonClick);//Solved it. VS is just not quickly catching up

            myButton.Click += delegate{
                new AlertDialog.Builder(this)
                .SetPositiveButton("OK",delegate
                {
                    //This code will just log to our console
                    // here's a snippet for console.WritelIne
                    Console.WriteLine("OK Button Clicked");
                })
                .SetNegativeButton("Cancel",delegate{
                Console.WriteLine("Cancel clicked");
                })
                .SetMessage("That was a rough one \nfor Android")
                .SetTitle("Xamarin and C# rocks")
                .Show();
            };
            }


        }
    }

