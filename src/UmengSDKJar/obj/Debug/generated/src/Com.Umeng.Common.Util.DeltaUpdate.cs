using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.common.util']/class[@name='DeltaUpdate']"
	[global::Android.Runtime.Register ("com/umeng/common/util/DeltaUpdate", DoNotGenerateAcw=true)]
	public partial class DeltaUpdate : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/common/util/DeltaUpdate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeltaUpdate); }
		}

		protected DeltaUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.common.util']/class[@name='DeltaUpdate']/constructor[@name='DeltaUpdate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DeltaUpdate () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeltaUpdate)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.util']/class[@name='DeltaUpdate']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public static bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_a);
		}

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.util']/class[@name='DeltaUpdate']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.util']/class[@name='DeltaUpdate']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static int A (string p0, string p1, string p2)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_b_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.util']/class[@name='DeltaUpdate']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string B (global::Android.Content.Context p0)
		{
			if (id_b_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_bspatch_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.util']/class[@name='DeltaUpdate']/method[@name='bspatch' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("bspatch", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static int Bspatch (string p0, string p1, string p2)
		{
			if (id_bspatch_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_bspatch_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "bspatch", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_bspatch_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}
}
