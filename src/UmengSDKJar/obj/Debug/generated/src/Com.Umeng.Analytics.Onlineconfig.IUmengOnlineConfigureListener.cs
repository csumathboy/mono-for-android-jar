using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Analytics.Onlineconfig {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.analytics.onlineconfig']/interface[@name='UmengOnlineConfigureListener']"
	[Register ("com/umeng/analytics/onlineconfig/UmengOnlineConfigureListener", "", "Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerInvoker")]
	public partial interface IUmengOnlineConfigureListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.analytics.onlineconfig']/interface[@name='UmengOnlineConfigureListener']/method[@name='onDataReceived' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("onDataReceived", "(Lorg/json/JSONObject;)V", "GetOnDataReceived_Lorg_json_JSONObject_Handler:Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerInvoker, UmengSDKJar")]
		void OnDataReceived (global::Org.Json.JSONObject p0);

	}

	[global::Android.Runtime.Register ("com/umeng/analytics/onlineconfig/UmengOnlineConfigureListener", DoNotGenerateAcw=true)]
	internal class IUmengOnlineConfigureListenerInvoker : global::Java.Lang.Object, IUmengOnlineConfigureListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/analytics/onlineconfig/UmengOnlineConfigureListener");
		IntPtr class_ref;

		public static IUmengOnlineConfigureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUmengOnlineConfigureListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.analytics.onlineconfig.UmengOnlineConfigureListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUmengOnlineConfigureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUmengOnlineConfigureListenerInvoker); }
		}

		static Delegate cb_onDataReceived_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetOnDataReceived_Lorg_json_JSONObject_Handler ()
		{
			if (cb_onDataReceived_Lorg_json_JSONObject_ == null)
				cb_onDataReceived_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDataReceived_Lorg_json_JSONObject_);
			return cb_onDataReceived_Lorg_json_JSONObject_;
		}

		static void n_OnDataReceived_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDataReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDataReceived_Lorg_json_JSONObject_;
		public void OnDataReceived (global::Org.Json.JSONObject p0)
		{
			if (id_onDataReceived_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_onDataReceived_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onDataReceived", "(Lorg/json/JSONObject;)V");
			JNIEnv.CallVoidMethod (Handle, id_onDataReceived_Lorg_json_JSONObject_, new JValue (p0));
		}

	}

	public partial class UmengOnlineConfigureEventArgs : global::System.EventArgs {

		public UmengOnlineConfigureEventArgs (global::Org.Json.JSONObject p0)
		{
			this.p0 = p0;
		}

		global::Org.Json.JSONObject p0;
		public global::Org.Json.JSONObject P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/umeng/analytics/onlineconfig/UmengOnlineConfigureListenerImplementor")]
	internal sealed class IUmengOnlineConfigureListenerImplementor : global::Java.Lang.Object, IUmengOnlineConfigureListener {

		object sender;

		public IUmengOnlineConfigureListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/umeng/analytics/onlineconfig/UmengOnlineConfigureListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<UmengOnlineConfigureEventArgs> Handler;
#pragma warning restore 0649

		public void OnDataReceived (global::Org.Json.JSONObject p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new UmengOnlineConfigureEventArgs (p0));
		}

		internal static bool __IsEmpty (IUmengOnlineConfigureListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
