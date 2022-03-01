using UnityEngine;

public abstract class Shape : MonoBehaviour
{
	public string Name { get; protected set; }
	public float Param1 { get; protected set; }


	protected virtual void Awake ()
	{
		GetComponent<SpriteRenderer> ().color = Random.ColorHSV ();
		ChangeScale ();
		Destroy (gameObject, Random.Range (2f, 10f));
	}

	protected virtual void ChangeScale ()
	{
		Param1 = Random.Range (0.5f, 2f);

		transform.localScale = new Vector2 (Param1, Param1);
	}

	protected virtual void OnMouseDown ()
	{
		GameManager.OnDisplayInfo?.Invoke (UpdateText ());
	}

	protected virtual string UpdateText ()
	{
		return $"Je suis un {Name}, de côté {Param1:0.00} m. Ma surface est donc de {Surface ():0.000} m².";
	}

	protected virtual float Surface () => 0f;
}