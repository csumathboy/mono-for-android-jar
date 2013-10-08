using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']"
	[global::Android.Runtime.Register ("com/umeng/common/Log", DoNotGenerateAcw=true)]
	public partial class Log : global::Java.Lang.Object {


		static IntPtr LOG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/field[@name='LOG']"
		[Register ("LOG")]
		public static bool Logs {
			get {
				if (LOG_jfieldId == IntPtr.Zero)
					LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, LOG_jfieldId);
			}
			set {
				if (LOG_jfieldId == IntPtr.Zero)
					LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG", "Z");
				JNIEnv.SetStaticField (class_ref, LOG_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/common/Log", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Log); }
		}

		protected Log (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/constructor[@name='Log' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Log () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Log)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static void A (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_b_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void B (string p0, string p1)
		{
			if (id_b_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='b' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("b", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static void B (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_c_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='c' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("c", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void C (string p0, string p1)
		{
			if (id_c_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='c' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("c", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static void C (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void D (string p0, string p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static void D (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void E (string p0, string p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common']/class[@name='Log']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static void E (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
