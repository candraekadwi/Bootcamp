namespace Day7_Project1;

public class Cat
{
	private MyDelegate _sound;
	public void Sound()
	{
		if(_sound != null)
		{
			_sound.Invoke("Meow");
		}
	}
	public bool AddSound(MyDelegate x)
	{
		if(!_sound.GetInvocationList().Contains(x))
		{
			_sound +=x;
			return true;
		}
		return false;
	}
	
	public void RemoveSound(MyDelegate x)
	{
		_sound -= x;
	}
}
