using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float force = 1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(1, 0.5f) , ForceMode2D.Impulse);
    }

    void Update()
    {

    }
}
