package crc64e880f74b0c0a6082;


public class SceneViewRenderer
	extends crc64e880f74b0c0a6082.GeoViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Esri.ArcGISRuntime.Xamarin.Forms.Platform.Android.SceneViewRenderer, Esri.ArcGISRuntime.Xamarin.Forms", SceneViewRenderer.class, __md_methods);
	}


	public SceneViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SceneViewRenderer.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Xamarin.Forms.Platform.Android.SceneViewRenderer, Esri.ArcGISRuntime.Xamarin.Forms", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SceneViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SceneViewRenderer.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Xamarin.Forms.Platform.Android.SceneViewRenderer, Esri.ArcGISRuntime.Xamarin.Forms", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SceneViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SceneViewRenderer.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Xamarin.Forms.Platform.Android.SceneViewRenderer, Esri.ArcGISRuntime.Xamarin.Forms", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
