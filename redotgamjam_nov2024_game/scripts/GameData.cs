using Godot;
using System;

public partial class GameData : Node
{
	public static GameData Instance { get; private set; }

	// Initial Volume Slider Values
	public float MasterVolume { get; set; } = 0.75f;
	public float MusicVolume { get; set; } = 0.5f;
	public float SFXVolume { get; set; } = 0.65f;

	// Game Variables

	// General Metadata
	// Is a run in progress
	public bool IsGameInProgress { get; set; } = false;
	// Can the player pause the game
	public bool IsGamePausable { get; set; } = false;
	// Is the game paused
	public bool IsGamePaused { get; set; } = false;
	// Has the player won the game
	public bool IsGameWon { get; set; } = false;
	// Has the player lost the game
	public bool IsGameLost { get; set; } = false;
	// 

	// Battle Metadata
	// Has the player won the battle
	public bool IsBattleWon { get; set; } = false;
	// Has the player lost the battle
	public bool IsBattleLost { get; set; } = false;

	// Worlds Metadata
	// Has the MainMenuWorld been killed
	public bool IsMainMenuWorldDead { get; set; } = false;
	// Has the GameMapWorld been killed
	public bool IsGameMapWorldDead { get; set; } = false;



	// Amount of enemy units defeated
	// Amount of bosses defeated
	// Amount of runes collected
	// Amount of player units lost

	// Player Variables

	// Amount of Runes the Player has currently
	public int CurrentPlayerRunes { get; set; } = 0;
	// Amount of Mana Cores the Player has currently
	public int CurrentManaCores { get; set; } = 0;

	

    public override void _Ready()
    {
        Instance = this;
    }
}
