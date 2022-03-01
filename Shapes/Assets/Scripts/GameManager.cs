using System.Collections.Generic;

using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
	public static System.Action<string> OnDisplayInfo;

	[SerializeField] private List<Shape> list;
	[SerializeField] private TMP_Text infoText;

	private void Start ()
	{
		InvokeRepeating (nameof (CreateShape), 0.5f, 3f);
	}

	private void CreateShape ()
	{
		Vector3 position = new Vector2 (Random.Range (-9f, 9f), Random.Range (-4f, 4f));
		Instantiate (list[Random.Range (0, list.Count)], position, Quaternion.identity);		
	}

	private void OnEnable () => OnDisplayInfo += DisplayInfo;

	private void OnDisable () => OnDisplayInfo -= DisplayInfo;

	private void DisplayInfo (string _info)
	{
		infoText.text = _info;
		infoText.enabled = true;
	}
}