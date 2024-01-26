using Godot;
using System;

public interface State
{
	State doState(Player player);
}
