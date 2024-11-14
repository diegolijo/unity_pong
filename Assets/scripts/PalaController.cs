using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float MAX_Y = 4.4f;
    [SerializeField] float MIN_Y = -4.4f;
    [SerializeField] float speed = 20.0f;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.up * speed * -Time.deltaTime);
        }
        if (transform.position.y > MAX_Y)
        {
            transform.position = new Vector3(8, MAX_Y, 0);
        }

        if (transform.position.y < MIN_Y)
        {
            transform.position = new Vector3(8, MIN_Y, 0);
        }
    }
}
