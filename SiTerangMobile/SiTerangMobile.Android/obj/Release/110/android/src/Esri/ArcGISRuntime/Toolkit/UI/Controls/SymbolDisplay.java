package Esri.ArcGISRuntime.Toolkit.UI.Controls;


public class SymbolDisplay
	extends android.widget.ImageView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Esri.ArcGISRuntime.Toolkit.UI.Controls.SymbolDisplay, Esri.ArcGISRuntime.Toolkit", SymbolDisplay.class, __md_methods);
	}


	public SymbolDisplay (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SymbolDisplay.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Toolkit.UI.Controls.SymbolDisplay, Esri.ArcGISRuntime.Toolkit", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SymbolDisplay (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SymbolDisplay.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Toolkit.UI.Controls.SymbolDisplay, Esri.ArcGISRuntime.Toolkit", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SymbolDisplay (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SymbolDisplay.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Toolkit.UI.Controls.SymbolDisplay, Esri.ArcGISRuntime.Toolkit", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
