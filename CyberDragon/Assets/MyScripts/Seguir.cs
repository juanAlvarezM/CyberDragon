using UnityEngine;
using System.Collections;

public class Seguir : MonoBehaviour {

	public Transform m_Jugador;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update () {
		GetComponent<UnityEngine.AI.NavMeshAgent>().destination = m_Jugador.position;
		}
}

