using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 5;
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
		//this.transform.position = Time.deltaTime * Vector3 right;

		//Vector3.forward
		//Vector3.up
		//vector3.down
		this.transform.Translate( (Time.deltaTime * speed) * Vector3.forward);
	}
}
