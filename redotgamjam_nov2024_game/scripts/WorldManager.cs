using Godot;
using System;

public partial class WorldManager : Node3D
{
	// Signals

	// Exports
	// Main Menu World Instance
	[Export] 
	public PackedScene MainMenuWorldScene { get; set; }

	// Properties

	// Methods

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		MainMenuWorld mainMenuWorld = MainMenuWorldScene.Instantiate<MainMenuWorld>();
		AddChild(mainMenuWorld);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
