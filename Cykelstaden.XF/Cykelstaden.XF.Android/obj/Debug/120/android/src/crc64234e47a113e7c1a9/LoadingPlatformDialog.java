package crc64234e47a113e7c1a9;


public class LoadingPlatformDialog
	extends androidx.fragment.app.DialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateDialog:(Landroid/os/Bundle;)Landroid/app/Dialog;:GetOnCreateDialog_Landroid_os_Bundle_Handler\n" +
			"n_onStart:()V:GetOnStartHandler\n" +
			"n_onDestroyView:()V:GetOnDestroyViewHandler\n" +
			"";
		mono.android.Runtime.register ("AiForms.Dialogs.LoadingPlatformDialog, AiForms.Dialogs", LoadingPlatformDialog.class, __md_methods);
	}


	public LoadingPlatformDialog ()
	{
		super ();
		if (getClass () == LoadingPlatformDialog.class)
			mono.android.TypeManager.Activate ("AiForms.Dialogs.LoadingPlatformDialog, AiForms.Dialogs", "", this, new java.lang.Object[] {  });
	}


	public LoadingPlatformDialog (int p0)
	{
		super (p0);
		if (getClass () == LoadingPlatformDialog.class)
			mono.android.TypeManager.Activate ("AiForms.Dialogs.LoadingPlatformDialog, AiForms.Dialogs", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public android.app.Dialog onCreateDialog (android.os.Bundle p0)
	{
		return n_onCreateDialog (p0);
	}

	private native android.app.Dialog n_onCreateDialog (android.os.Bundle p0);


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();


	public void onDestroyView ()
	{
		n_onDestroyView ();
	}

	private native void n_onDestroyView ();

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
