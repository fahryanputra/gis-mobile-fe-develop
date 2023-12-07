package crc64da0e62ce9292a623;


public abstract class UserInteractionHandler
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Esri.ArcGISRuntime.UI.UserInteractionHandler, Esri.ArcGISRuntime.Android", UserInteractionHandler.class, __md_methods);
	}


	public UserInteractionHandler ()
	{
		super ();
		if (getClass () == UserInteractionHandler.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.UI.UserInteractionHandler, Esri.ArcGISRuntime.Android", "", this, new java.lang.Object[] {  });
	}

	public UserInteractionHandler (crc64ed7a4a679bf6b924.GeoView p0)
	{
		super ();
		if (getClass () == UserInteractionHandler.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.UI.UserInteractionHandler, Esri.ArcGISRuntime.Android", "Esri.ArcGISRuntime.UI.Controls.GeoView, Esri.ArcGISRuntime.Android", this, new java.lang.Object[] { p0 });
	}

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
