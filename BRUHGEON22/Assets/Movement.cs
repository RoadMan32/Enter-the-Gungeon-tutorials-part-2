using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float Verti;
    float Horizont;
    public Rigidbody2D Rb;
    public GameObject[] sides;
    public Vector2 Direction;
    public bool DodgeRoll;
    public float DodgeSpeed;
    public float DodgeTime;

    public GameObject Front;
    public GameObject Left;
    public GameObject Right;
    public GameObject back;
    public Vector2 direcooo;
    // Start is called before the first frame update
    void Start()
    {
        Rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DodgeRoll)
        {
            Rb.velocity=new Vector2(Direction.x*DodgeSpeed, Direction.y*DodgeSpeed);
        }
        Horizont = Input.GetAxisRaw("Horizontal");
        Verti = Input.GetAxisRaw("Vertical");

        if (Horizont > 0 || Horizont < 0 || Verti < 0 || Verti > 0)
        {
            for (int i = 0; i < sides.Length; i++)
            {
                sides[i].GetComponent<Animator>().SetBool("Walking", true);
            }
        }
        else
        {
            for (int i = 0; i < sides.Length; i++)
            {
                sides[i].GetComponent<Animator>().SetBool("Walking", false);
            }
      
        }
     
        if(Horizont>0|| Horizont<0 ||Verti<0 || Verti > 0)
        {
            if (Input.GetMouseButtonDown(1) && !IsRolling.IsRollin)
            {
                for (int i = 0; i < sides.Length; i++)
                {
                    GoToDirection();
                    sides[0].GetComponent<Animator>().SetTrigger("Rollin");
                    sides[1].GetComponent<Animator>().SetTrigger("Rollin");
                    sides[2].GetComponent<Animator>().SetTrigger("Rollin");
                    sides[3].GetComponent<Animator>().SetTrigger("Rollin");
                    Direction = new Vector2(Horizont, Verti);
                    StartCoroutine(Roll());

                  
                }
            }
        }


    }
    private void FixedUpdate()
    {
        if (DodgeRoll==false)
        {
            Rb.velocity = new Vector2(Horizont, Verti);
        }
      
    }
    IEnumerator Roll()
    {
        DodgeRoll = true;
        yield return new WaitForSeconds(DodgeTime);
        DodgeRoll = false;
    }
    void GoToDirection()
    {
        if (Direction.x == 0 && Direction.y == -1)
        {
            Front.SetActive(true);
            Left.SetActive(false);
            Right.SetActive(false);
            back.SetActive(false);
        }
        if (Direction.x == 1 && Direction.y == 0)
        {
            Front.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(true);
            back.SetActive(false);
        }
        if (Direction.x == -1 && Direction.y == 0)
        {
            Front.SetActive(false);
            Left.SetActive(true);
            Right.SetActive(false);
            back.SetActive(false);
        }
        if (Direction.x == 0&& Direction.y ==1)
        {
            back.SetActive(true);
            Front.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(false);
           
        }


        if (Direction.x == 1 && Direction.y == 1)
        {
            back.SetActive(false);
            Front.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(true);

        }
        if (Direction.x == 1 && Direction.y == -1)
        {
            back.SetActive(false);
            Front.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(true);

        }
        if (Direction.x == -1 && Direction.y == 1)
        {
            back.SetActive(false);
            Front.SetActive(false);
            Left.SetActive(true);
            Right.SetActive(false);

        }
        if (Direction.x == -1 && Direction.y == -1)
        {
            back.SetActive(false);
            Front.SetActive(false);
            Left.SetActive(true);
            Right.SetActive(false);

        }
    }
}
