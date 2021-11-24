package crc64234e47a113e7c1a9;


public class LoadingDialogPayload
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
		mono.android.Runtime.register ("AiForms.Dialogs.LoadingDialogPayload, AiForms.Dialogs", LoadingDialogPayload.class, __md_methods);
	}


	public LoadingDialogPayload ()
	{
		super ();
		if (getClass () == LoadingDialogPayload.class)
			mono.android.TypeManager.Activate ("AiForms.Dialogs.LoadingDialogPayload, AiForms.Dialogs", "", this, new java.lang.Object[] {  });
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
