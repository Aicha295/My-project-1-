using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public float rotspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.M))
        {
            transform.Translate(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, -rotspeed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.K))
        {
            transform.Rotate(0, rotspeed, 0);
        }
    }
}
