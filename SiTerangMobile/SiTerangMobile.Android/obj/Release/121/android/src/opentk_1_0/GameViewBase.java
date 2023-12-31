package opentk_1_0;


public abstract class GameViewBase
	extends android.view.SurfaceView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("OpenTK.GameViewBase, OpenTK-1.0", GameViewBase.class, __md_methods);
	}


	public GameViewBase (android.content.Context p0)
	{
		super (p0);
		if (getClass () == GameViewBase.class)
			mono.android.TypeManager.Activate ("OpenTK.GameViewBase, OpenTK-1.0", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public GameViewBase (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == GameViewBase.class)
			mono.android.TypeManager.Activate ("OpenTK.GameViewBase, OpenTK-1.0", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public GameViewBase (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == GameViewBase.class)
			mono.android.TypeManager.Activate ("OpenTK.GameViewBase, OpenTK-1.0", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
