using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;

    public GameObject[] GlobulesPrefabs;

    private int RandomGlobule;   


    // Update is called once per frame
    void Update()
    {
        //blanc ou rouge
        RandomGlobule = Random.Range(0, 2);

        if (Input.GetButtonDown("Fire1"))
        {
           Instantiate(GlobulesPrefabs[RandomGlobule], firePoint.position, firePoint.rotation); 
        }
    }



}//class
