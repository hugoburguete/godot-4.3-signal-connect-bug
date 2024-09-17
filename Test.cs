using Godot;

public partial class Test : Control
{
	public void OnButtonClickWithParams(int i)
	{
		GD.Print(i);
	}
}