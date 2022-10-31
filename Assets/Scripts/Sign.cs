using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Sign : MonoBehaviour
{

	public GameObject dialogBox;
	public TextMeshProUGUI dialogText;
	public string dialog;
	public bool inRange;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && inRange)
		{
			if (dialogBox.activeInHierarchy)
			{
				dialogBox.SetActive(false);
			} 
			else
			{
				dialogBox.SetActive(true);
				dialogText.text = dialog;
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			inRange = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			inRange = false;
			dialogBox.SetActive(false);
		}
	}
}
