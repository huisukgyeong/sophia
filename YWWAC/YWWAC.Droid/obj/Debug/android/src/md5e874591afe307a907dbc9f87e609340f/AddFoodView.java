package md5e874591afe307a907dbc9f87e609340f;


public class AddFoodView
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("YWWAC.Droid.Views.AddFoodView, YWWAC.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AddFoodView.class, __md_methods);
	}


	public AddFoodView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AddFoodView.class)
			mono.android.TypeManager.Activate ("YWWAC.Droid.Views.AddFoodView, YWWAC.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
