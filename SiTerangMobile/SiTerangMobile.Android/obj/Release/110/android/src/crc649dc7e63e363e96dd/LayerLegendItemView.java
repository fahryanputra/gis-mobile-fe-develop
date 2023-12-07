package crc649dc7e63e363e96dd;


public class LayerLegendItemView
	extends android.widget.LinearLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Esri.ArcGISRuntime.Toolkit.UI.Controls.LayerLegendItemView, Esri.ArcGISRuntime.Toolkit", LayerLegendItemView.class, __md_methods);
	}


	public LayerLegendItemView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == LayerLegendItemView.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Toolkit.UI.Controls.LayerLegendItemView, Esri.ArcGISRuntime.Toolkit", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public LayerLegendItemView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == LayerLegendItemView.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Toolkit.UI.Controls.LayerLegendItemView, Esri.ArcGISRuntime.Toolkit", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public LayerLegendItemView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == LayerLegendItemView.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Toolkit.UI.Controls.LayerLegendItemView, Esri.ArcGISRuntime.Toolkit", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
