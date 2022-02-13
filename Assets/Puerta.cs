using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour
{
    public int nivel;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Jugador")
        {
            SceneManager.LoadScene(nivel);
        }
    }
}


