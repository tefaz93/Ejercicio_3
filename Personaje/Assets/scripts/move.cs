using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		moveForward ();
	}
	//funcion que mueve al personaje
	public void moveForward ()
	{
		Debug.Log ("Hola");
		//Mover posicion de forma constante
		//this.transform.position = new Vector3 (5,0,1);
		this.transform.position = Time.deltaTime * Vector3.right;
	}
}
