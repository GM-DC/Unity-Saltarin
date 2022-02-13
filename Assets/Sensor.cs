using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public static bool colisiona;

    private void OnTriggerEnter2D(Collider2D other) {
        colisiona = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        colisiona = false;
    }
}
