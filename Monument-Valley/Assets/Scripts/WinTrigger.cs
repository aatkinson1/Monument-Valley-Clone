using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
	public Text WinText;

	void Start()
	{
		WinText.enabled = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("WinTrigger")) 
		{
			WinText.enabled = true;
		}
	}
}
