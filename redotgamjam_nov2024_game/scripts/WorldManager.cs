using Godot;
using System;

public partial class WorldManager : Node3D
{
	// Signals

	// Exports
	// Main Menu World Instance
	[Export] 
	public PackedScene MainMenuWorldScene { get; set; }
	// Game Map World Instance
	[Export] 
	public PackedScene GameMapWorldScene { get; set; }

	// Properties
	// Access to the GameData variables
	private GameData _gameData;
	// Access to the CustomSignals signals
	private CustomSignals _customSignals;


	// Methods

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		MainMenuWorld mainMenuWorld = MainMenuWorldScene.Instantiate<MainMenuWorld>();
		AddChild(mainMenuWorld);

		_customSignals = GetTree().Root.GetNode<CustomSignals>("CustomSignals");
		_gameData = GetTree().Root.GetNode<GameData>("GameData");

		_customSignals.FirstTimeLoadGameMapWorld += HandleFirstTimeLoadGameMapWorld;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	// Handle loading GameMapWorld for the first time
	private void HandleFirstTimeLoadGameMapWorld()
	{
		GD.Print("First time loading GameMapWorld for this run");
		GameMapWorld gameMapWorld = GameMapWorldScene.Instantiate<GameMapWorld>();
		AddChild(gameMapWorld);

	}
}
