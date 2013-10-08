using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Common.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.common.net']/class[@name='DownloadingService']"
	[global::Android.Runtime.Register ("com/umeng/common/net/DownloadingService", DoNotGenerateAcw=true)]
	public partial class DownloadingService : global::Android.App.Service {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.common.net']/class[@name='DownloadingService']/field[@name='e']"
		[Register ("e")]
		public const int E = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.common.net']/class[@name='DownloadingService']/field[@name='f']"
		[Register ("f")]
		public const int F = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.common.net']/class[@name='DownloadingService']/field[@name='g']"
		[Register ("g")]
		public const int G = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.common.net']/class[@name='DownloadingService']/field[@name='h']"
		[Register ("h")]
		public const int H = (int) 3;

		static IntPtr m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.common.net']/class[@name='DownloadingService']/field[@name='m']"
		[Register ("m")]
		public static bool M {
			get {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, m_jfieldId);
			}
			set {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "Z");
				JNIEnv.SetStaticField (class_ref, m_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/common/net/DownloadingService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadingService); }
		}

		protected DownloadingService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.common.net']/class[@name='DownloadingService']/constructor[@name='DownloadingService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DownloadingService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DownloadingService)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_a_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_;
		}

		static void n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Common.Net.DownloadingService __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Common.Net.DownloadingService> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.net']/class[@name='DownloadingService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "GetA_Ljava_lang_String_Handler")]
		public virtual void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Common.Net.DownloadingService __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Common.Net.DownloadingService> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.net']/class[@name='DownloadingService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");

			global::Android.OS.IBinder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_onBind_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_onBind_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
