using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace app
{
	[Activity (Label = "app", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
		protected override  void OnResume ()
		{
			base.OnResume ();
			//直接用桥接语言调用
			JavaLibaryHelper.UmengOnResume (this);
			//用mono转的C#类库调用
			Com.Umeng.Analytics.MobclickAgent.OnResume (this);
		}

		protected override void OnPause ()
		{
			base.OnPause ();
			//直接用桥接语言调用
			JavaLibaryHelper.UmengOnPause (this);
			//用mono转的C#类库调用
			Com.Umeng.Analytics.MobclickAgent.OnPause (this);
		}
	}

}


