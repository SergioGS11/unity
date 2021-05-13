using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [Tooltip("Velocidad del jugador")]
    public float playerSpeed;

    [Tooltip("Límite de la pantalla")]
    public float screenLimit;

    void Update() {
        // Movimiento hacia la izquierda del jugador
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(-playerSpeed, 0, 0);
            // Evita que el jugador se salga de la pantalla
            if (transform.position.x < -screenLimit) {
                transform.position = new Vector3(-screenLimit, transform.position.y, transform.position.z);
            }
        }
        // Movimiento hacia la derecha del jugador
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(playerSpeed, 0, 0);
            // Evita que el jugador se salga de la pantalla
            if (transform.position.x > screenLimit) {
                transform.position = new Vector3(screenLimit, transform.position.y, transform.position.z);
            }
        }
    }
}