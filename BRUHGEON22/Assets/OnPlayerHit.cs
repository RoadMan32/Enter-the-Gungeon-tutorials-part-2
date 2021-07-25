using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().health -= 1;
            Destroy(gameObject);
        }
    }
}
