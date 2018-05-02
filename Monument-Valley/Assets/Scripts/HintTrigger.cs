using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintTrigger : MonoBehaviour
{
	public Text HintText;

	void Start()
	{
		HintText.enabled = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Hint Key")) 
		{
			HintText.enabled = true;
		}
	}
}