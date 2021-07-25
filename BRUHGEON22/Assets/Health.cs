using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public float MaxHealth;
    // Start is called before the first frame update
    void Start()
    {
        health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health > MaxHealth)
        {
            health = MaxHealth;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
