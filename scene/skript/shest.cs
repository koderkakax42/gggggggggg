using Godot;
using System;

public partial class shest : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_button() 
	{
       QueueFree();
	   ui_pc_player.nomber_open_chest--;
	}
}
