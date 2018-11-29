using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andarTeclado : MonoBehaviour {

    public float velocidad = 30;
    private Rigidbody2D rg;

	// Use this for initialization
	void Start () {
        rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float velocidad_y = rg.velocity.y;
        float velocidad_x = Input.GetAxis("Horizontal") * velocidad;

        Vector2 vectorVelocidad = new Vector2(velocidad_x, velocidad_y); //vector que une ambos ejes

        rg.velocity = vectorVelocidad;
    }
}
