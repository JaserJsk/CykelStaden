package crc64234e47a113e7c1a9;


public class ExtraPlatformDialog
	extends androidx.fragment.app.DialogFragment
	implements
		mono.android.IGCUserPeer,
		android.content.DialogInterface.OnKeyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateDialog:(Landroid/os/Bundle;)Landroid/app/Dialog;:GetOnCreateDialog_Landroid_os_Bundle_Handler\n" +
			"n_onStart:()V:GetOnStartHandler\n" +
			"n_onDestroyView:()V:GetOnDestroyViewHandler\n" +
			"n_onKey:(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z:GetOnKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_Handler:Android.Content.IDialogInterfaceOnKeyListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("AiForms.Dialogs.ExtraPlatformDialog, AiForms.Dialogs", ExtraPlatformDialog.class, __md_methods);
	}


	public ExtraPlatformDialog ()
	{
		super ();
		if (getClass () == ExtraPlatformDialog.class)
			mono.android.TypeManager.Activate ("AiForms.Dialogs.ExtraPlatformDialog, AiForms.Dialogs", "", this, new java.lang.Object[] {  });
	}


	public ExtraPlatformDialog (int p0)
	{
		super (p0);
		if (getClass () == ExtraPlatformDialog.class)
			mono.android.TypeManager.Activate ("AiForms.Dialogs.ExtraPlatformDialog, AiForms.Dialogs", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
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


	public boolean onKey (android.content.DialogInterface p0, int p1, android.view.KeyEvent p2)
	{
		return n_onKey (p0, p1, p2);
	}

	private native boolean n_onKey (android.content.DialogInterface p0, int p1, android.view.KeyEvent p2);

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
