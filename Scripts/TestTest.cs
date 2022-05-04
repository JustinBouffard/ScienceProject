using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestTest : MonoBehaviour
{
    [SerializeField]
    private GameObject text;

    private int score;


    public void Response()
    {
        score++;
    }


    public void _button()
    {
        Instantiate(text);
    }
    


}
