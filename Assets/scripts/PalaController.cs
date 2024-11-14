using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            //Stransform.Translate(new Vector3(0, .1f, 0));
            transform.Translate(Vector3.up * .1f);
        };

        if (Input.GetKey("down"))
        {
            //transform.Translate(new Vector3(0, -.1f, 0));
            transform.Translate(Vector3.up * -.1f);
        };
    }
}
