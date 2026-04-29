using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerRotate : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    public void OnLook(InputValue value)
    {
        Vector2 mousePos = value.Get<Vector2>();
        Vector3 worldPos = cam.ScreenToWorldPoint(mousePos);
        worldPos.z = 0f;

        Vector2 direction = worldPos - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
