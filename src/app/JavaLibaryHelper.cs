using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace app
{
	/// <summary>
	/// Java libary helper.
	/// java类库
	/// </summary>
	public static class JavaLibaryHelper
	{
		#region umeng class
		private static IntPtr _umengHelperClass = JNIEnv.FindClass("com/umeng/analytics/MobclickAgent");

		public static void UmengOnResume(Context context)	
		{
			IntPtr methodId = JNIEnv.GetStaticMethodID(_umengHelperClass, "onResume", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod(_umengHelperClass, methodId,new JValue(context));

		}

		public static void UmengOnPause(Context context)
		{		
			IntPtr methodId = JNIEnv.GetStaticMethodID(_umengHelperClass, "onPause", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod(_umengHelperClass, methodId,new JValue(context));
		}
		#endregion
	}


}

