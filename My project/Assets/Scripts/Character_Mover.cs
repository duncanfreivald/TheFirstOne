using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Mover : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            MoveLeftRight(Input.GetAxis("Horizontal"));
        }
    }
    public void MoveLeftRight(float axis)
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime * axis);
    }
}//
