using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpriteSelector : MonoBehaviour {
    [Tooltip("Referencia al SpriteRenderer del enemigo")]
    public SpriteRenderer spriteRenderer;

    [Tooltip("Listado de posibles sprites para el enemigo")]
    public List<Sprite> sprites;

    void Start() {
        // Elección aleatoria del sprite del enemigo
        spriteRenderer.sprite = sprites[Random.Range(0, sprites.Count)];
    }
}