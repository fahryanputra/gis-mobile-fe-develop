package crc64c3fca7979cc18263;


public class NetworkCredentialPrompt_UsernamePasswordDialog
	extends android.app.DialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onActivityCreated:(Landroid/os/Bundle;)V:GetOnActivityCreated_Landroid_os_Bundle_Handler\n" +
			"n_onDestroyView:()V:GetOnDestroyViewHandler\n" +
			"n_onCreateDialog:(Landroid/os/Bundle;)Landroid/app/Dialog;:GetOnCreateDialog_Landroid_os_Bundle_Handler\n" +
			"n_onCancel:(Landroid/content/DialogInterface;)V:GetOnCancel_Landroid_content_DialogInterface_Handler\n" +
			"";
		mono.android.Runtime.register ("Esri.ArcGISRuntime.UI.Security.NetworkCredentialPrompt+UsernamePasswordDialog, Esri.ArcGISRuntime", NetworkCredentialPrompt_UsernamePasswordDialog.class, __md_methods);
	}


	public NetworkCredentialPrompt_UsernamePasswordDialog ()
	{
		super ();
		if (getClass () == NetworkCredentialPrompt_UsernamePasswordDialog.class)
			mono.android.TypeManager.Activate ("Esri.ArcGISRuntime.UI.Security.NetworkCredentialPrompt+UsernamePasswordDialog, Esri.ArcGISRuntime", "", this, new java.lang.Object[] {  });
	}


	public void onActivityCreated (android.os.Bundle p0)
	{
		n_onActivityCreated (p0);
	}

	private native void n_onActivityCreated (android.os.Bundle p0);


	public void onDestroyView ()
	{
		n_onDestroyView ();
	}

	private native void n_onDestroyView ();


	public android.app.Dialog onCreateDialog (android.os.Bundle p0)
	{
		return n_onCreateDialog (p0);
	}

	private native android.app.Dialog n_onCreateDialog (android.os.Bundle p0);


	public void onCancel (android.content.DialogInterface p0)
	{
		n_onCancel (p0);
	}

	private native void n_onCancel (android.content.DialogInterface p0);

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
