using UnityEngine;

public class Circle : Shape
{
	protected override void Awake ()
	{
		base.Awake ();
		Name = "cercle";
	}

	protected override string UpdateText ()
	{
		return $"Je suis un {Name}, de rayon {Param1 * 0.5f:0.00} m. Ma surface est donc de {Surface ():0.000} m².";
	}

	protected override float Surface ()
	{
		return (transform.localScale.x * 0.5f) * (transform.localScale.x * 0.5f) * Mathf.PI;
	}
}