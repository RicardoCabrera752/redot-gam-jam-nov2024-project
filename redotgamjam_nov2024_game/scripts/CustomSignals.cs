using Godot;
using System;

public partial class CustomSignals : Node
{
	// Signals
	// Emitted when the Player selects a Clan and Starts the Game
	[Signal] 
	public delegate void KillMainMenuWorldEventHandler();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
