using UnityEngine;
using System.Collections;

public class Choque: MonoBehaviour {

	public delegate void metodoDelegado();
	public static metodoDelegado Evento;

	void OnCollisionEnter(Collision obj) {
		if (obj.gameObject.tag == "cubos") 
			Evento ();
	}
}
