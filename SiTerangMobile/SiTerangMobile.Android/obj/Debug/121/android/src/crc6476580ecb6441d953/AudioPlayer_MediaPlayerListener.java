package crc6476580ecb6441d953;


public class AudioPlayer_MediaPlayerListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.media.MediaPlayer.OnErrorListener,
		android.media.MediaPlayer.OnPreparedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(Landroid/media/MediaPlayer;II)Z:GetOnError_Landroid_media_MediaPlayer_IIHandler:Android.Media.MediaPlayer/IOnErrorListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onPrepared:(Landroid/media/MediaPlayer;)V:GetOnPrepared_Landroid_media_MediaPlayer_Handler:Android.Media.MediaPlayer/IOnPreparedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Esri.ArcGISRuntime.Ogc.AudioPlayer+MediaPlayerListener, Esri.ArcGISRuntime", AudioPlayer_MediaPlayerListener.class, __md_methods);
	}


	public AudioPlayer_MediaPlayerListener ()
	{
		super ();
		if (getClass () == AudioPlayer_MediaPlayerListener.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.Ogc.AudioPlayer+MediaPlayerListener, Esri.ArcGISRuntime", "", this, new java.lang.Object[] {  });
	}


	public boolean onError (android.media.MediaPlayer p0, int p1, int p2)
	{
		return n_onError (p0, p1, p2);
	}

	private native boolean n_onError (android.media.MediaPlayer p0, int p1, int p2);


	public void onPrepared (android.media.MediaPlayer p0)
	{
		n_onPrepared (p0);
	}

	private native void n_onPrepared (android.media.MediaPlayer p0);

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
