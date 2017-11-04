using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambioUI : MonoBehaviour {

	public Transform LoadingBar;
	public GameObject ESCENARIO;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "bala")
		{
			Debug.Log ("Entre!!!");
			if (currentAmount < 100) {
				currentAmount += speed * Time.deltaTime;
				Debug.Log (currentAmount);
				if (currentAmount >= 100) {

					currentAmount = 0;
					ESCENARIO.SetActive (false);
				}
			}

			LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
		}
	}
	void OnTriggerExit(Collider col)
	{
		currentAmount = 0;
		LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
	}
}
