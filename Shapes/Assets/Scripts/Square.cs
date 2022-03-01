public class Square : Shape
{
	protected override void Awake ()
	{
		base.Awake ();
		Name = "carré";
	}

	protected override float Surface ()
	{
		return transform.localScale.x * transform.localScale.y;
	}
}