using Godot;
using System;

public partial class level : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// on body entered
		Connect("body_entered", new Callable(this, nameof(OnBodyEntered)));		
		GD.Print("level script ready.");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	// on body entered
	private void OnBodyEntered(Node body)
	{
		GD.Print("+1");
		GD.Print("Body entered collision area: ", body.Name);
	}
}
