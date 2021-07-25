using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGunScript : MonoBehaviour
{
    public float Tbs;
    public GameObject Bullet;
    public bool CanShoot = true;
    public Transform Shootpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)&& CanShoot)
        {
            Instantiate(Bullet, Shootpoint.position, Shootpoint.rotation);
            StartCoroutine(Cooldown());
        }
    }

    IEnumerator Cooldown()
    {
        CanShoot = false;
        yield return new WaitForSeconds(Tbs);
        CanShoot = true;
    }
}
