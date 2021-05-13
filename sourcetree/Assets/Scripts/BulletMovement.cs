using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    [Tooltip("Velocidad de la bala")]
    public float bulletSpeed;

    void Start() {
        // La bala se destruirá a los 3 segundos para evitar problemas de memoria
        Destroy(gameObject, 3);
    }

    void Update() {
        // Movimiento de la bala en el eje Y según la velocidad especificada
        transform.Translate(0, bulletSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        // La bala se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);
    }
}