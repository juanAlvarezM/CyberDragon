using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambioUI : MonoBehaviour {

	public Transform LoadingBar;
	public GameObject galeriaNarativa;
	public GameObject botonNarrativa;
	public GameObject botonConcept;
	public GameObject galeriaConcept;
	public GameObject menu;

	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	// Use this for initialization
	void Start () {
		galeriaNarativa.SetActive (false);
		galeriaConcept.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Narrativa")
		{
			Debug.Log ("Entre!!!");
			if (currentAmount < 100) {
				currentAmount += speed * Time.deltaTime;
				Debug.Log (currentAmount);
				if (currentAmount >= 100) {

					currentAmount = 0;
					galeriaNarativa.SetActive (true);
					botonNarrativa.SetActive (false);
					botonConcept.SetActive (false);
					galeriaConcept.SetActive (false);
				}
			}

			LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
		}


		if (col.gameObject.tag == "ConceptArt") {
			Debug.Log ("Entre!!!");
			if (currentAmount < 100) {
				currentAmount += speed * Time.deltaTime;
				Debug.Log (currentAmount);
				if (currentAmount >= 100) {
					currentAmount = 0;
					galeriaNarativa.SetActive (false);
					botonConcept.SetActive (false);
					botonNarrativa.SetActive (false);
					galeriaConcept.SetActive (true);
				}
			}
			LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
		}
		if (col.gameObject.tag == "Home") {
			Debug.Log ("Entre!!!");
			if (currentAmount < 100) {
				currentAmount += speed * Time.deltaTime;
				Debug.Log (currentAmount);
				if (currentAmount >= 100) {
					currentAmount = 0;
					galeriaNarativa.SetActive (false);
					botonConcept.SetActive (true);
					botonNarrativa.SetActive (true);
					galeriaConcept.SetActive (false);
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
