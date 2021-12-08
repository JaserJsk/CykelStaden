package crc64234e47a113e7c1a9;


public class ExtraDialogPayload
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.io.Serializable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AiForms.Dialogs.ExtraDialogPayload, AiForms.Dialogs", ExtraDialogPayload.class, __md_methods);
	}


	public ExtraDialogPayload ()
	{
		super ();
		if (getClass () == ExtraDialogPayload.class)
			mono.android.TypeManager.Activate ("AiForms.Dialogs.ExtraDialogPayload, AiForms.Dialogs", "", this, new java.lang.Object[] {  });
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
