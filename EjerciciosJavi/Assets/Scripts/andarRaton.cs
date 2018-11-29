using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andarRaton : MonoBehaviour {

    Vector2 posicion_objetivo;
    public float speed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 nueva_posicion = new Vector2 (posicionMouse.x, transform.position.y); //la posicion en x va a ser la del raton y la y la mia (donde deje el personaje)

        if (Input.GetMouseButtonDown(0))
        {
            transform.//cada vez que haga click me voy a la posicion objetivo
        }
	}
}
