public class Square : Shape
{
	protected override void Awake ()
	{
		base.Awake ();
		Name = "carr�";
	}

	protected override float Surface ()
	{
		return transform.localScale.x * transform.localScale.y;
	}
}