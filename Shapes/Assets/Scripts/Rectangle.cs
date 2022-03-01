using UnityEngine;

public class Rectangle : Square
{
	public float Param2 { get; protected set; }

	protected override void Awake ()
	{
		base.Awake ();
		Name = "rectangle";
	}

	protected override string UpdateText ()
	{
		return $"Je suis un {Name}, de côtés {Param1:0.00} m et {Param2:0.00} m. Ma surface est donc de {Surface ():0.000} m².";
	}

	protected override void ChangeScale ()
	{
		Param1 = Random.Range (0.5f, 2f);
		Param2 = Random.Range (0.5f, 2f);

		transform.localScale = new Vector2 (Param1, Param2);
	}
}