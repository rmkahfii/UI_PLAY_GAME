using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 2f;
    public float batasKiri = -3f;
    public float batasKanan = 3f;

    private bool keKanan = true;

    void Update()
    {
        if (keKanan)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            if (transform.position.x >= batasKanan)
            {
                keKanan = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x <= batasKiri)
            {
                keKanan = true;
            }
        }
    }
}
