using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONEnemyHit : MonoBehaviour
{
    public float Damage;
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
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<Health>().health -= Damage;
            Destroy(gameObject);
        }
    }
}
