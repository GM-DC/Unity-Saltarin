using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D objeto) {
        if (objeto.gameObject.name=="pared")
        {
            transform.position = new Vector3(0,-3,0);
        }

    }

}
