using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShots : MonoBehaviour
{
    public GameObject Shot;
    public Transform Shotspawn;
    public float fireRate;

    private float nextFire;

    void Update()
    {
        if (Input.GetKey("up") && Time.time > nextFire)
        {
            if (Input.GetKey("left"))
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, 45)); 
            else if (Input.GetKey("right"))
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, -45)); 
            else
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, 0)); 

            nextFire = Time.time + fireRate;
        }
        else if (Input.GetKey("down") && Time.time > nextFire)
        {
            if (Input.GetKey("left"))
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, 135)); 
            else if (Input.GetKey("right"))
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, -135)); 
            else
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, 180)); 

            nextFire = Time.time + fireRate;
        }
        else if (Input.GetKey("left") && Time.time > nextFire)
        {
            if (Input.GetKey("up"))
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, 45)); 
            else if (Input.GetKey("down"))
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, 135)); 
            else
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, 90)); 

            nextFire = Time.time + fireRate;
        }
        else if (Input.GetKey("right") && Time.time > nextFire)
        {
            if (Input.GetKey("up"))
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, -45)); 
            else if (Input.GetKey("down"))
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, -135)); 
            else
                Instantiate(Shot, Shotspawn.position, Quaternion.Euler(0, 0, -90));

            nextFire = Time.time + fireRate;
        }
    }
}
