using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalQuestion : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public BoxCollider2D Collider;


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

        Destroy(gameObject);
        boxCollider.enabled = false;
        Collider.enabled = false;


        if (Globules.Score >= 5)
        {
            SceneManager.LoadScene("End");
        }
        else
        {
            SceneManager.LoadScene("OtherEnd");
        }

    }


}
