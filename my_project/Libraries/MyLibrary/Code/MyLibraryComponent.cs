using Sandbox;
using Sandbox.Citizen;

/// <summary>
/// This is a component - in your library!
/// </summary>
[Title( "My_Library - My Component" )]
public class MyLibraryComponent : Component
{
	[Property]
	public CitizenAnimationHelper AnimationHelper { get; set; }
}
