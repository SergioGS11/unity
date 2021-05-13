using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision) {
        // El enemigo se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);
    }
}