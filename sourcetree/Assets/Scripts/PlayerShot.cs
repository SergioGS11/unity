using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour {
    [Tooltip("Referencia al prefab de la bala")]
    public GameObject bulletPrefab;

    void Update() {
        // Instancia una bala cada vez que el jugador pulsa el espacio
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}