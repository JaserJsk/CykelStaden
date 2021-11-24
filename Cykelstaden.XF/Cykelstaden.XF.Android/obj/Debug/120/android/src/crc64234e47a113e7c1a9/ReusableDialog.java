package crc64234e47a113e7c1a9;


public class ReusableDialog
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AiForms.Dialogs.ReusableDialog, AiForms.Dialogs", ReusableDialog.class, __md_methods);
	}


	public ReusableDialog ()
	{
		super ();
		if (getClass () == ReusableDialog.class)
			mono.android.TypeManager.Activate ("AiForms.Dialogs.ReusableDialog, AiForms.Dialogs", "", this, new java.lang.Object[] {  });
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
