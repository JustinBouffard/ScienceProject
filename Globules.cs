using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globules : MonoBehaviour
{

    [HideInInspector]
    public static int Score = 0;


    [SerializeField]
    private GameObject GlobulesBlancs;
    [SerializeField]
    private GameObject Globulesrouges;

    private Rigidbody2D RigidBody;


    private void Awake()
    {
        RigidBody = GetComponent<Rigidbody2D>();
    }

    private float speed = 20f;


    // Start is called before the first frame update
    void Start()
    {
        RigidBody.velocity = transform.right * speed;       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.name == "Good")
        {
            Score += 1;
            Debug.Log("Score is : " + Score);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("ResponseBad"))
        {
            Destroy(gameObject);
        }

        //destroyBullets When out of map
        if (collision.gameObject.CompareTag("DestroyBullet"))
        {
            Destroy(gameObject);
        }

    }//end



}//class
