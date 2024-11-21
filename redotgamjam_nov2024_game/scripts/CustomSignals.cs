using Godot;
using System;

public partial class CustomSignals : Node
{
	// Signals
	// Emitted when the Player starts a run, sent to kill MainMenuWorld
	[Signal] 
	public delegate void KillMainMenuWorldEventHandler();
	// Emitted when the GameMapWorld is loaded for a new run
	[Signal] 
	public delegate void FirstTimeLoadGameMapWorldEventHandler();


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
