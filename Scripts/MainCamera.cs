using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform Player;
    public Vector3 offSet;
    public float damping;

    private Vector3 velocity = Vector3.zero;


    private void FixedUpdate()
    {
       
        Vector3 movePosition = Player.position + offSet;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
    }

}//class
