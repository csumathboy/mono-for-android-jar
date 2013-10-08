using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']"
	[global::Android.Runtime.Register ("com/umeng/analytics/MobclickAgent", DoNotGenerateAcw=true)]
	public partial class MobclickAgent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/analytics/MobclickAgent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobclickAgent); }
		}

		protected MobclickAgent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/constructor[@name='MobclickAgent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MobclickAgent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MobclickAgent)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_flush_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='flush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("flush", "(Landroid/content/Context;)V", "")]
		public static void Flush (global::Android.Content.Context p0)
		{
			if (id_flush_Landroid_content_Context_ == IntPtr.Zero)
				id_flush_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "flush", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_flush_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_getConfigParams_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='getConfigParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getConfigParams", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetConfigParams (global::Android.Content.Context p0, string p1)
		{
			if (id_getConfigParams_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getConfigParams_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getConfigParams", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConfigParams_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_onError_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onError", "(Landroid/content/Context;)V", "")]
		public static void OnError (global::Android.Content.Context p0)
		{
			if (id_onError_Landroid_content_Context_ == IntPtr.Zero)
				id_onError_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "onError", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onError_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_onError_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onError", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void OnError (global::Android.Content.Context p0, string p1)
		{
			if (id_onError_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onError_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onError", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onError_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_onEvent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEvent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onEvent", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void OnEvent (global::Android.Content.Context p0, string p1)
		{
			if (id_onEvent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onEvent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onEvent", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEvent_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_onEvent_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("onEvent", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public static void OnEvent (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_onEvent_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_onEvent_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "onEvent", "(Landroid/content/Context;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEvent_Landroid_content_Context_Ljava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void OnEvent (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("onEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public static void OnEvent (global::Android.Content.Context p0, string p1, string p2, int p3)
		{
			if (id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "onEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.HashMap']]"
		[Register ("onEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/HashMap;)V", "")]
		public static void OnEvent (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_ == IntPtr.Zero)
				id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_ = JNIEnv.GetStaticMethodID (class_ref, "onEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/HashMap;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_, new JValue (p0), new JValue (native_p1), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_onEventBegin_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEventBegin' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onEventBegin", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void OnEventBegin (global::Android.Content.Context p0, string p1)
		{
			if (id_onEventBegin_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onEventBegin_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onEventBegin", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEventBegin_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_onEventBegin_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEventBegin' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onEventBegin", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void OnEventBegin (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_onEventBegin_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onEventBegin_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onEventBegin", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEventBegin_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_onEventDuration_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEventDuration' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("onEventDuration", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;J)V", "")]
		public static void OnEventDuration (global::Android.Content.Context p0, string p1, string p2, long p3)
		{
			if (id_onEventDuration_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_onEventDuration_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "onEventDuration", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEventDuration_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_J, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_onEventDuration_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEventDuration' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.HashMap'] and parameter[4][@type='long']]"
		[Register ("onEventDuration", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/HashMap;J)V", "")]
		public static void OnEventDuration (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2, long p3)
		{
			if (id_onEventDuration_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_J == IntPtr.Zero)
				id_onEventDuration_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_J = JNIEnv.GetStaticMethodID (class_ref, "onEventDuration", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/HashMap;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEventDuration_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_J, new JValue (p0), new JValue (native_p1), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_onEventDuration_Landroid_content_Context_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEventDuration' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("onEventDuration", "(Landroid/content/Context;Ljava/lang/String;J)V", "")]
		public static void OnEventDuration (global::Android.Content.Context p0, string p1, long p2)
		{
			if (id_onEventDuration_Landroid_content_Context_Ljava_lang_String_J == IntPtr.Zero)
				id_onEventDuration_Landroid_content_Context_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "onEventDuration", "(Landroid/content/Context;Ljava/lang/String;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEventDuration_Landroid_content_Context_Ljava_lang_String_J, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_onEventEnd_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEventEnd' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onEventEnd", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void OnEventEnd (global::Android.Content.Context p0, string p1)
		{
			if (id_onEventEnd_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onEventEnd_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onEventEnd", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEventEnd_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_onEventEnd_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onEventEnd' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onEventEnd", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void OnEventEnd (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_onEventEnd_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onEventEnd_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onEventEnd", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onEventEnd_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_onKVEventBegin_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onKVEventBegin' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.HashMap'] and parameter[4][@type='java.lang.String']]"
		[Register ("onKVEventBegin", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)V", "")]
		public static void OnKVEventBegin (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2, string p3)
		{
			if (id_onKVEventBegin_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_Ljava_lang_String_ == IntPtr.Zero)
				id_onKVEventBegin_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onKVEventBegin", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onKVEventBegin_Landroid_content_Context_Ljava_lang_String_Ljava_util_HashMap_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_onKVEventEnd_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onKVEventEnd' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onKVEventEnd", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void OnKVEventEnd (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_onKVEventEnd_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onKVEventEnd_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onKVEventEnd", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onKVEventEnd_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_onKillProcess_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onKillProcess' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onKillProcess", "(Landroid/content/Context;)V", "")]
		public static void OnKillProcess (global::Android.Content.Context p0)
		{
			if (id_onKillProcess_Landroid_content_Context_ == IntPtr.Zero)
				id_onKillProcess_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "onKillProcess", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onKillProcess_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_onPause_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onPause", "(Landroid/content/Context;)V", "")]
		public static void OnPause (global::Android.Content.Context p0)
		{
			if (id_onPause_Landroid_content_Context_ == IntPtr.Zero)
				id_onPause_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "onPause", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onPause_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_onResume_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onResume", "(Landroid/content/Context;)V", "")]
		public static void OnResume (global::Android.Content.Context p0)
		{
			if (id_onResume_Landroid_content_Context_ == IntPtr.Zero)
				id_onResume_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "onResume", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onResume_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_onResume_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='onResume' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onResume", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void OnResume (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_onResume_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onResume_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onResume", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onResume_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_openActivityDurationTrack_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='openActivityDurationTrack' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("openActivityDurationTrack", "(Z)V", "")]
		public static void OpenActivityDurationTrack (bool p0)
		{
			if (id_openActivityDurationTrack_Z == IntPtr.Zero)
				id_openActivityDurationTrack_Z = JNIEnv.GetStaticMethodID (class_ref, "openActivityDurationTrack", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_openActivityDurationTrack_Z, new JValue (p0));
		}

		static IntPtr id_reportError_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='reportError' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportError", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void ReportError (global::Android.Content.Context p0, string p1)
		{
			if (id_reportError_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_reportError_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportError", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_reportError_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_reportError_Landroid_content_Context_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='reportError' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("reportError", "(Landroid/content/Context;Ljava/lang/Throwable;)V", "")]
		public static void ReportError (global::Android.Content.Context p0, global::Java.Lang.Throwable p1)
		{
			if (id_reportError_Landroid_content_Context_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_reportError_Landroid_content_Context_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "reportError", "(Landroid/content/Context;Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_reportError_Landroid_content_Context_Ljava_lang_Throwable_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setAge_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetSetAge_Landroid_content_Context_IHandler ()
		{
			if (cb_setAge_Landroid_content_Context_I == null)
				cb_setAge_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetAge_Landroid_content_Context_I);
			return cb_setAge_Landroid_content_Context_I;
		}

		static void n_SetAge_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Analytics.MobclickAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.MobclickAgent> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAge (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAge_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setAge' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setAge", "(Landroid/content/Context;I)V", "GetSetAge_Landroid_content_Context_IHandler")]
		public virtual void SetAge (global::Android.Content.Context p0, int p1)
		{
			if (id_setAge_Landroid_content_Context_I == IntPtr.Zero)
				id_setAge_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "setAge", "(Landroid/content/Context;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAge_Landroid_content_Context_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAge_Landroid_content_Context_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setAutoLocation_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setAutoLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoLocation", "(Z)V", "")]
		public static void SetAutoLocation (bool p0)
		{
			if (id_setAutoLocation_Z == IntPtr.Zero)
				id_setAutoLocation_Z = JNIEnv.GetStaticMethodID (class_ref, "setAutoLocation", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setAutoLocation_Z, new JValue (p0));
		}

		static IntPtr id_setDebugMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setDebugMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebugMode", "(Z)V", "")]
		public static void SetDebugMode (bool p0)
		{
			if (id_setDebugMode_Z == IntPtr.Zero)
				id_setDebugMode_Z = JNIEnv.GetStaticMethodID (class_ref, "setDebugMode", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebugMode_Z, new JValue (p0));
		}

		static IntPtr id_setDefaultReportPolicy_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setDefaultReportPolicy' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setDefaultReportPolicy", "(Landroid/content/Context;I)V", "")]
		public static void SetDefaultReportPolicy (global::Android.Content.Context p0, int p1)
		{
			if (id_setDefaultReportPolicy_Landroid_content_Context_I == IntPtr.Zero)
				id_setDefaultReportPolicy_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "setDefaultReportPolicy", "(Landroid/content/Context;I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultReportPolicy_Landroid_content_Context_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setEnableEventBuffer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setEnableEventBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableEventBuffer", "(Z)V", "")]
		public static void SetEnableEventBuffer (bool p0)
		{
			if (id_setEnableEventBuffer_Z == IntPtr.Zero)
				id_setEnableEventBuffer_Z = JNIEnv.GetStaticMethodID (class_ref, "setEnableEventBuffer", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnableEventBuffer_Z, new JValue (p0));
		}

		static Delegate cb_setGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_;
#pragma warning disable 0169
		static Delegate GetSetGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_Handler ()
		{
			if (cb_setGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_ == null)
				cb_setGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_);
			return cb_setGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_;
		}

		static void n_SetGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Analytics.MobclickAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.MobclickAgent> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Analytics.Gender p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.Gender> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetGender (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setGender' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.analytics.Gender']]"
		[Register ("setGender", "(Landroid/content/Context;Lcom/umeng/analytics/Gender;)V", "GetSetGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_Handler")]
		public virtual void SetGender (global::Android.Content.Context p0, global::Com.Umeng.Analytics.Gender p1)
		{
			if (id_setGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_ == IntPtr.Zero)
				id_setGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_ = JNIEnv.GetMethodID (class_ref, "setGender", "(Landroid/content/Context;Lcom/umeng/analytics/Gender;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setGender_Landroid_content_Context_Lcom_umeng_analytics_Gender_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setOnlineConfigureListener_Lcom_umeng_analytics_onlineconfig_UmengOnlineConfigureListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setOnlineConfigureListener' and count(parameter)=1 and parameter[1][@type='com.umeng.analytics.onlineconfig.UmengOnlineConfigureListener']]"
		[Register ("setOnlineConfigureListener", "(Lcom/umeng/analytics/onlineconfig/UmengOnlineConfigureListener;)V", "")]
		public static void SetOnlineConfigureListener (global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListener p0)
		{
			if (id_setOnlineConfigureListener_Lcom_umeng_analytics_onlineconfig_UmengOnlineConfigureListener_ == IntPtr.Zero)
				id_setOnlineConfigureListener_Lcom_umeng_analytics_onlineconfig_UmengOnlineConfigureListener_ = JNIEnv.GetStaticMethodID (class_ref, "setOnlineConfigureListener", "(Lcom/umeng/analytics/onlineconfig/UmengOnlineConfigureListener;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnlineConfigureListener_Lcom_umeng_analytics_onlineconfig_UmengOnlineConfigureListener_, new JValue (p0));
		}

		static IntPtr id_setOpenGLContext_Ljavax_microedition_khronos_opengles_GL10_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setOpenGLContext' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
		[Register ("setOpenGLContext", "(Ljavax/microedition/khronos/opengles/GL10;)V", "")]
		public static void SetOpenGLContext (global::Javax.Microedition.Khronos.Opengles.IGL10 p0)
		{
			if (id_setOpenGLContext_Ljavax_microedition_khronos_opengles_GL10_ == IntPtr.Zero)
				id_setOpenGLContext_Ljavax_microedition_khronos_opengles_GL10_ = JNIEnv.GetStaticMethodID (class_ref, "setOpenGLContext", "(Ljavax/microedition/khronos/opengles/GL10;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setOpenGLContext_Ljavax_microedition_khronos_opengles_GL10_, new JValue (p0));
		}

		static IntPtr id_setSessionContinueMillis_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setSessionContinueMillis' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setSessionContinueMillis", "(J)V", "")]
		public static void SetSessionContinueMillis (long p0)
		{
			if (id_setSessionContinueMillis_J == IntPtr.Zero)
				id_setSessionContinueMillis_J = JNIEnv.GetStaticMethodID (class_ref, "setSessionContinueMillis", "(J)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setSessionContinueMillis_J, new JValue (p0));
		}

		static Delegate cb_setUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_setUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Analytics.MobclickAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.MobclickAgent> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetUserID (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setUserID' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setUserID", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetSetUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetUserID (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_setUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserID", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setUserID_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_setWrapper_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='setWrapper' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setWrapper", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void SetWrapper (string p0, string p1)
		{
			if (id_setWrapper_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setWrapper_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setWrapper", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setWrapper_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_updateOnlineConfig_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='updateOnlineConfig' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateOnlineConfig", "(Landroid/content/Context;)V", "")]
		public static void UpdateOnlineConfig (global::Android.Content.Context p0)
		{
			if (id_updateOnlineConfig_Landroid_content_Context_ == IntPtr.Zero)
				id_updateOnlineConfig_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "updateOnlineConfig", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_updateOnlineConfig_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_updateOnlineConfig_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics']/class[@name='MobclickAgent']/method[@name='updateOnlineConfig' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("updateOnlineConfig", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void UpdateOnlineConfig (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_updateOnlineConfig_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateOnlineConfig_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "updateOnlineConfig", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_updateOnlineConfig_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

#region "Event implementation for Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListener"
		public event EventHandler<global::Com.Umeng.Analytics.Onlineconfig.UmengOnlineConfigureEventArgs> lineConfigure {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListener, global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerImplementor>(
						ref weak_implementor_SetOnlineConfigureListener,
						__CreateIUmengOnlineConfigureListenerImplementor,
						SetOnlineConfigureListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListener, global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerImplementor>(
						ref weak_implementor_SetOnlineConfigureListener,
						global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerImplementor.__IsEmpty,
						__v => SetOnlineConfigureListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnlineConfigureListener;

		global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerImplementor __CreateIUmengOnlineConfigureListenerImplementor ()
		{
			return new global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerImplementor (this);
		}
#endregion
	}
}
