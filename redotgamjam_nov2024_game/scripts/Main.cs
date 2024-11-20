using Godot;
using System;

public partial class Main : Node
{
	// Signals

	// Exports

	// Properties
	// Audio Bus Indices
	public int MasterVolumeIndex = AudioServer.GetBusIndex("Master");
	public int MusicVolumeIndex = AudioServer.GetBusIndex("Music");
	public int SFXVolumeIndex = AudioServer.GetBusIndex("SFX");

	// Initial Volume Slider Values
	//public float MasterVolume = 1;
	//public float MusicVolume = 1;
	//public float SFXVolume = 1;


	// Methods

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var gameData = GetTree().Root.GetNode<GameData>("GameData");
		var MasterVolume = gameData.MasterVolume;
		var MusicVolume = gameData.MusicVolume;
		var SFXVolume = gameData.SFXVolume;

		// Initialize the Volume Slider Values
		GetNode<HSlider>("UIManager/OptionsUI/MasterVolumeSlider").Value = MasterVolume;
		GetNode<HSlider>("UIManager/OptionsUI/MusicVolumeSlider").Value = MusicVolume;
		GetNode<HSlider>("UIManager/OptionsUI/SoundEffectsVolumeSlider").Value = SFXVolume;


		// Play the Main Menu Music
		GetNode<AudioStreamPlayer>("AudioManager/MainMenuMusic").Play();


		//GetNode<Node3D>("WorldManager").AddChild(mainMenuWorld);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	// Handle Game Exit
	private void OnExitGame()
	{
		GetTree().Quit();
	}

	// Handle Master Volume Slider Changes
	private void OnChangeMasterVolume(float value)
	{
		AudioServer.SetBusVolumeDb(MasterVolumeIndex, Mathf.LinearToDb(value));
		GetTree().Root.GetNode<GameData>("GameData").MasterVolume = value;
	}

	// Handle Music Volume Slider Changes
	private void OnChangeMusicVolume(float value)
	{
		AudioServer.SetBusVolumeDb(MusicVolumeIndex, Mathf.LinearToDb(value));
		GetTree().Root.GetNode<GameData>("GameData").MusicVolume = value;
	}

	// Handle SFX Volume Slider Changes
	private void OnChangeSoundEffectsVolume(float value)
	{
		AudioServer.SetBusVolumeDb(SFXVolumeIndex, Mathf.LinearToDb(value));
		GetTree().Root.GetNode<GameData>("GameData").SFXVolume = value;
	}

	// Handle Game Start
	private void OnStartGame()
	{
		GetNode<AudioStreamPlayer>("AudioManager/MainMenuMusic").Stop();
		
		//GetTree().ChangeSceneToFile("res://game_world.tscn");
	}
}
