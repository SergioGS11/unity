using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [Tooltip("Velocidad del enemigo")]
    public float enemySpeed;

    void Update() {
        // Movimiento del enemigo en el eje Y según la velocidad especificada
        transform.Translate(0, -enemySpeed, 0);
    }
}