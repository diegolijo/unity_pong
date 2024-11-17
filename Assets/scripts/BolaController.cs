using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class BolaController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] GameManager manager;
    [SerializeField] float force;
    [SerializeField] float MIN_DEG = 20f;
    [SerializeField] float MAX_DEG = 50f;
    public Vector3 resetPosition;
    private int delay = 2;

    float MAX_Y = 4.0f;
    float MIN_Y = -4.0f;

    void Start()
    {
        force = 0.8f;
        resetPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        int dirX = new[] { -1, 1 }[Random.Range(0, 2)];
        StartCoroutine(LaunchBall(dirX));
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;

        if (tag == "paddle_r")
        {

        }
        if (tag == "paddle_l")
        {

        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        string tag = collider.tag;
        Debug.Log(tag);
        if (tag == "goal_r")
        {
            manager.addScoreL();
            StartCoroutine(LaunchBall(1));
        }
        if (tag == "goal_l")
        {

            manager.addScoreR();
            StartCoroutine(LaunchBall(-1));
        }
    }


    IEnumerator LaunchBall(int dirX)
    {
        yield return new WaitForSeconds(delay);

        float posY = Random.Range(MIN_Y, MAX_Y);
        transform.position = new Vector3(resetPosition.x, posY, 0);

        float deg = Random.Range(MIN_DEG, MAX_DEG) * Mathf.Deg2Rad;
        float x = Mathf.Cos(deg) * dirX;

        int dirY = new[] { -1, 1 }[Random.Range(0, 2)];
        float y = Mathf.Sin(deg) * dirY;

        Vector2 impulse = new Vector2(x, y);

        rb.velocity = Vector2.zero;
        rb.AddForce(impulse * force, ForceMode2D.Impulse);

    }
}
