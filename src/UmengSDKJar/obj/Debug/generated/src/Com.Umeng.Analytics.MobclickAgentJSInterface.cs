using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgentJSInterface']"
	[global::Android.Runtime.Register ("com/umeng/analytics/MobclickAgentJSInterface", DoNotGenerateAcw=true)]
	public partial class MobclickAgentJSInterface : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/analytics/MobclickAgentJSInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobclickAgentJSInterface); }
		}

		protected MobclickAgentJSInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_webkit_WebView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgentJSInterface']/constructor[@name='MobclickAgentJSInterface' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.webkit.WebView']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/webkit/WebView;)V", "")]
		public MobclickAgentJSInterface (global::Android.Content.Context p0, global::Android.Webkit.WebView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MobclickAgentJSInterface)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Landroid/webkit/WebView;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/webkit/WebView;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Landroid_webkit_WebView_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_webkit_WebView_Landroid_webkit_WebChromeClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgentJSInterface']/constructor[@name='MobclickAgentJSInterface' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.webkit.WebView'] and parameter[3][@type='android.webkit.WebChromeClient']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/webkit/WebView;Landroid/webkit/WebChromeClient;)V", "")]
		public MobclickAgentJSInterface (global::Android.Content.Context p0, global::Android.Webkit.WebView p1, global::Android.Webkit.WebChromeClient p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MobclickAgentJSInterface)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Landroid/webkit/WebView;Landroid/webkit/WebChromeClient;)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_webkit_WebView_Landroid_webkit_WebChromeClient_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_webkit_WebView_Landroid_webkit_WebChromeClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/webkit/WebView;Landroid/webkit/WebChromeClient;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Landroid_webkit_WebView_Landroid_webkit_WebChromeClient_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
