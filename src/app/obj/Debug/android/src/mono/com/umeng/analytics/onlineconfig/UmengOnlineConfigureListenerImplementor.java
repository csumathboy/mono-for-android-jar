package mono.com.umeng.analytics.onlineconfig;


public class UmengOnlineConfigureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.umeng.analytics.onlineconfig.UmengOnlineConfigureListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onDataReceived:(Lorg/json/JSONObject;)V:GetOnDataReceived_Lorg_json_JSONObject_Handler:Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerInvoker, UmengSDKJar\n" +
			"";
		mono.android.Runtime.register ("Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerImplementor, UmengSDKJar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", UmengOnlineConfigureListenerImplementor.class, __md_methods);
	}


	public UmengOnlineConfigureListenerImplementor ()
	{
		super ();
		if (getClass () == UmengOnlineConfigureListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Umeng.Analytics.Onlineconfig.IUmengOnlineConfigureListenerImplementor, UmengSDKJar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDataReceived (org.json.JSONObject p0)
	{
		n_onDataReceived (p0);
	}

	private native void n_onDataReceived (org.json.JSONObject p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
