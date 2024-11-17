using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    float MAX_Y = 4.5f;
    float MIN_Y = -4.5f;
    [SerializeField] float speed;
    void Start()
    {
        speed = 10f;
    }

    void Update()
    {

        if (gameObject.CompareTag("paddle_r"))
        {
            if (Input.GetKey("up"))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            if (Input.GetKey("down"))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }

        if (gameObject.CompareTag("paddle_l"))
        {
            if (Input.GetKey("a"))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            if (Input.GetKey("z"))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }

        Vector3 newPosition = transform.position;
        if (transform.position.y > MAX_Y)
        {
            newPosition.y = MAX_Y;
            transform.position = newPosition;
        }
        if (transform.position.y < MIN_Y)
        {
            newPosition.y = MIN_Y;
            transform.position = newPosition;
        }

    }
}
