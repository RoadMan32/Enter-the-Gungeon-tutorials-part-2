using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPointRotate : MonoBehaviour
{
    public float RotationAmount;
    public Transform ShootPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootPoint.rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z + Random.Range(RotationAmount, RotationAmount * -1));
    }
}
