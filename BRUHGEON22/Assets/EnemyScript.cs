using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent Nma;
    public Transform Target;
    public float Cooldown;
    public float AnimationOffset;
    public GameObject Bullet;
    public Transform Shootpoint;
    // Start is called before the first frame update
    void Start()
    {
        Nma.updateRotation = false;
        Nma.updateUpAxis = false;
        StartCoroutine(cooldown());
    }

    // Update is called once per frame
    void Update()
    {
        Nma.SetDestination(Target.position);
    }

    IEnumerator Shoot()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Attack");
        yield return new WaitForSeconds(AnimationOffset);
        Instantiate(Bullet, Shootpoint.position, Shootpoint.rotation);
        StartCoroutine(cooldown());
    }
    IEnumerator cooldown()
    {
        yield return new WaitForSeconds(Cooldown);
        StartCoroutine(Shoot());
    }
}
