using Godot;
using System;

public partial class level : Area2D
{
	public override void _Ready()
	{
		Connect("body_entered", new Callable(this, nameof(OnBodyEntered)));		
		GD.Print("level script ready.");
	}

	public override void _Process(double delta)
	{
	}

	private void OnBodyEntered(Node body)
	{
		GD.Print("+1");
		GD.Print("Body entered collision area: ", body.Name);
	}
}
