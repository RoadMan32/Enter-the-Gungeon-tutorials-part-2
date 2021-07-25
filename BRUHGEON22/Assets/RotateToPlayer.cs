using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public Transform Target;
    public bool facingRight = true;
    public Transform Enemy;
    public float RotationAmount;
    // Start is called before the first frame update
    void Start()
    {
        var delta = Target.position - transform.position;

        if (delta.x >= 0 && !facingRight)
        {
            Enemy.localScale = new Vector3(1, 1, 1);
            facingRight = true;
        }
        if (delta.x <= 0 && facingRight)
        {
            Enemy.localScale = new Vector3(-1, 1, 1);
            facingRight = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diffrence = Target.position - transform.position;
        diffrence.Normalize();

        float rotationZ = Mathf.Atan2(diffrence.y, diffrence.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        var delta = Target.position - transform.position;

        if(delta.x>=0 && !facingRight)
        {
            Enemy.localScale = new Vector3(1, 1, 1);
            facingRight = true;
        }
        if (delta.x <= 0 && facingRight)
        {
            Enemy.localScale = new Vector3(-1, 1, 1);
            facingRight = false;
        }
    }
}
