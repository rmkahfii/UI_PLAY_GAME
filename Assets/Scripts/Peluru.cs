using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        Destroy(gameObject, 1f);
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
