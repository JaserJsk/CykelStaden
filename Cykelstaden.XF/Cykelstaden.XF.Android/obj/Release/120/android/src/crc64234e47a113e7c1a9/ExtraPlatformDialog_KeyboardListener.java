package crc64234e47a113e7c1a9;


public class ExtraPlatformDialog_KeyboardListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.ViewTreeObserver.OnGlobalLayoutListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGlobalLayout:()V:GetOnGlobalLayoutHandler:Android.Views.ViewTreeObserver/IOnGlobalLayoutListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("AiForms.Dialogs.ExtraPlatformDialog+KeyboardListener, AiForms.Dialogs", ExtraPlatformDialog_KeyboardListener.class, __md_methods);
	}


	public ExtraPlatformDialog_KeyboardListener ()
	{
		super ();
		if (getClass () == ExtraPlatformDialog_KeyboardListener.class)
			mono.android.TypeManager.Activate ("AiForms.Dialogs.ExtraPlatformDialog+KeyboardListener, AiForms.Dialogs", "", this, new java.lang.Object[] {  });
	}

	public ExtraPlatformDialog_KeyboardListener (android.view.View p0, crc64234e47a113e7c1a9.ExtraPlatformDialog p1)
	{
		super ();
		if (getClass () == ExtraPlatformDialog_KeyboardListener.class)
			mono.android.TypeManager.Activate ("AiForms.Dialogs.ExtraPlatformDialog+KeyboardListener, AiForms.Dialogs", "Android.Views.View, Mono.Android:AiForms.Dialogs.ExtraPlatformDialog, AiForms.Dialogs", this, new java.lang.Object[] { p0, p1 });
	}


	public void onGlobalLayout ()
	{
		n_onGlobalLayout ();
	}

	private native void n_onGlobalLayout ();

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
