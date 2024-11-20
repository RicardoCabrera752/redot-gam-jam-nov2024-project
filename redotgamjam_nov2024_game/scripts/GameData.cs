using Godot;
using System;

public partial class GameData : Node
{
	public static GameData Instance { get; private set; }

	// Initial Volume Slider Values
	public float MasterVolume { get; set; } = 0.75f;
	public float MusicVolume { get; set; } = 0.5f;
	public float SFXVolume { get; set; } = 0.65f;

	// Player Variables
	

    public override void _Ready()
    {
        Instance = this;
    }
}
