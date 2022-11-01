using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ public float bulletspeed = 10;


    // Start is called before the first frame update
    private void Start()
    {
        Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * bulletspeed * Time.deltaTime);
    }
}