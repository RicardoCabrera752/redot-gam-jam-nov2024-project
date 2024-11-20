using Godot;
using System;

public partial class UIManager : Control
{
	// Signals
	// Emitted when the player wants to quit the game
	[Signal] 
	public delegate void ExitGameEventHandler();

	// Emitted when the player starts the game
	[Signal] 
	public delegate void StartGameEventHandler();

	// Emitted when the player changes the Master Volume
	[Signal] 
	public delegate void ChangeMasterVolumeEventHandler(float value);

	// Emitted when the player changes the Music Volume
	[Signal] 
	public delegate void ChangeMusicVolumeEventHandler(float value);

	// Emitted when the player changes the SFX Volume
	[Signal] 
	public delegate void ChangeSoundEffectsVolumeEventHandler(float value);

	// Properties
	public bool ShowMainMenuScreen = true;
	public bool ShowStartScreen = false;
	public bool ShowControlsScreen = false;
	public bool ShowOptionsScreen = false;
	public bool ShowCreditsScreen = false;

	// Methods

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Safety check to display correct UI
		GetNode<CanvasLayer>("MainMenuUI").Show();
		GetNode<CanvasLayer>("StartUI").Hide();
		GetNode<CanvasLayer>("ControlsUI").Hide();
		GetNode<CanvasLayer>("OptionsUI").Hide();
		GetNode<CanvasLayer>("CreditsUI").Hide();
		GetNode<CanvasLayer>("BackButtonUI").Hide();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	// Handle Start Button being pressed
	private void OnStartButtonPressed()
	{
		GD.Print("Start Button Pressed");
		GetNode<CanvasLayer>("BackButtonUI").Show();
		GetNode<CanvasLayer>("MainMenuUI").Hide();
		GetNode<CanvasLayer>("StartUI").Show();
		ShowStartScreen = true;
		GetNode<AudioStreamPlayer>("../AudioManager/ButtonSoundEffect").Play();
	}

	// Handle Controls Button being pressed
	private void OnControlsButtonPressed()
	{
		GD.Print("Controls Button Pressed");
		GetNode<CanvasLayer>("BackButtonUI").Show();
		GetNode<CanvasLayer>("MainMenuUI").Hide();
		GetNode<CanvasLayer>("ControlsUI").Show();
		ShowControlsScreen = true;
		GetNode<AudioStreamPlayer>("../AudioManager/ButtonSoundEffect").Play();
	}

	// Handle Options Button being pressed
	private void OnOptionsButtonPressed()
	{
		GD.Print("Options Button Pressed");
		GetNode<CanvasLayer>("BackButtonUI").Show();
		GetNode<CanvasLayer>("MainMenuUI").Hide();
		GetNode<CanvasLayer>("OptionsUI").Show();
		ShowOptionsScreen = true;
		GetNode<AudioStreamPlayer>("../AudioManager/ButtonSoundEffect").Play();
	}

	// Handle Credits Button being pressed
	private void OnCreditsButtonPressed()
	{
		GD.Print("Credits Button Pressed");
		GetNode<CanvasLayer>("BackButtonUI").Show();
		GetNode<CanvasLayer>("MainMenuUI").Hide();
		GetNode<CanvasLayer>("CreditsUI").Show();
		ShowCreditsScreen = true;
		GetNode<AudioStreamPlayer>("../AudioManager/ButtonSoundEffect").Play();
	}

	// Handle Exit Button being pressed
	private void OnExitButtonPressed()
	{
		EmitSignal(SignalName.ExitGame);
	}

	// Handle Back Button being pressed
	private void OnBackButtonPressed()
	{
		GD.Print("Back Button Pressed");
		GetNode<CanvasLayer>("BackButtonUI").Hide();

		if(ShowStartScreen)
		{
			GetNode<CanvasLayer>("StartUI").Hide();
			ShowStartScreen = false;
		}

		if(ShowControlsScreen)
		{
			GetNode<CanvasLayer>("ControlsUI").Hide();
			ShowControlsScreen = false;
		}

		if(ShowOptionsScreen)
		{
			GetNode<CanvasLayer>("OptionsUI").Hide();
			ShowOptionsScreen = false;
		}

		if(ShowCreditsScreen)
		{
			GetNode<CanvasLayer>("CreditsUI").Hide();
			ShowCreditsScreen = false;
		}


		GetNode<CanvasLayer>("MainMenuUI").Show();
		GetNode<AudioStreamPlayer>("../AudioManager/ButtonSoundEffect").Play();
	}

	// Handle Start Game Button being pressed
	private void OnStartGameButtonPressed()
	{
		GD.Print("Start Game Button Pressed");
		EmitSignal(SignalName.StartGame);
	}

	// Handle Master Volume Slider Changes
	private void OnMasterVolumeSliderValueChanged(float value)
	{
		//GD.Print(value);
		EmitSignal(SignalName.ChangeMasterVolume, value);
	}

	// Handle Music Volume Slider Changes
	private void OnMusicVolumeSliderValueChanged(float value)
	{
		EmitSignal(SignalName.ChangeMusicVolume, value);
	}

	// Handle SFX Volume Slider Changes
	private void OnSoundEffectsVolumeSliderValueChanged(float value)
	{
		EmitSignal(SignalName.ChangeSoundEffectsVolume, value);
	}
}
