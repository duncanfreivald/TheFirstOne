using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{public float speed = 4f;
    bool isFacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFacingRight && transform.position.x < 3)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            isFacingRight = false;
        }
        if(isFacingRight==false && transform.position.x > -3)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else
        {
            isFacingRight = true;
        }
    }// false
    
}
////teh "callback", or the action that occurs when something is triggered
//public UnityEvent OnCollide;

//private void OnCollisionEnter(Collision col)
//{
//    OnCollide.Invoke();
////}//deltaTime means the cahnge in time since the last time the update funciton was called
//transform.Translate(Vector3.right * speed * Time.deltaTime);