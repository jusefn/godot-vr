using Godot;

public partial class MainNode : Node
{
	
	private XRInterface _xrInterface;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_xrInterface = XRServer.FindInterface("OpenXR");
		if (_xrInterface != null && _xrInterface.IsInitialized())
		{
			GD.Print("OpenXR initialized successfully");
			
			// Turn off v-sync!
			DisplayServer.WindowSetVsyncMode(DisplayServer.VSyncMode.Disabled);
			
			// Change main viewport to output to the HMD
			GetViewport().UseXR = true;
		}
		else
		{
			GD.Print("OpenXR not initialized, please check if your headset is connected");
		}
	}
}
