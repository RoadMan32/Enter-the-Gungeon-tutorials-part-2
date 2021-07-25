using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float BulletSpeed;
    public float Lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Rb.velocity = transform.right * BulletSpeed;
        Destroy(gameObject, Lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
