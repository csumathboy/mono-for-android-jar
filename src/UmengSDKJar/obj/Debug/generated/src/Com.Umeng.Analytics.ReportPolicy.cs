using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.analytics']/class[@name='ReportPolicy']"
	[global::Android.Runtime.Register ("com/umeng/analytics/ReportPolicy", DoNotGenerateAcw=true)]
	public partial class ReportPolicy : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.analytics']/class[@name='ReportPolicy']/field[@name='BATCH_AT_LAUNCH']"
		[Register ("BATCH_AT_LAUNCH")]
		public const int BatchAtLaunch = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.analytics']/class[@name='ReportPolicy']/field[@name='BATCH_BY_INTERVAL']"
		[Register ("BATCH_BY_INTERVAL")]
		public const int BatchByInterval = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.analytics']/class[@name='ReportPolicy']/field[@name='DAILY']"
		[Register ("DAILY")]
		public const int Daily = (int) 4;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/analytics/ReportPolicy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReportPolicy); }
		}

		protected ReportPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.analytics']/class[@name='ReportPolicy']/constructor[@name='ReportPolicy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ReportPolicy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ReportPolicy)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

	}
}
