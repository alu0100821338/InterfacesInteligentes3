using UnityEngine;
using System.Collections;

public class cambio : MonoBehaviour {


	// Use this for initialization
	void Start () {
		Choque.Evento += Rotar;
	}

	// Girar los cubos y cambiarlos de color
	void Rotar () {
		this.gameObject.transform.Rotate (Vector3.right, 60, Space.World);
		this.gameObject.transform.Rotate (Vector3.up, 20, Space.World);

		Color color = new Color (Random.value,  Random.value, Random.value);
		this.gameObject.GetComponent<Renderer> ().material.color = color;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
