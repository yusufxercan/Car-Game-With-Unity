using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerspeed = 200;
    [SerializeField] float movespeed = 20;
    [SerializeField] float boostspeed = 30;
    [SerializeField] float whendestroy = 1;
    [SerializeField] float slowtspeed = 20;
    bool haspackage = false;


    
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float speedamount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Translate(0, speedamount, 0);
        transform.Rotate(0, 0, -steeramount);
       
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        movespeed = slowtspeed;

    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Customer" && haspackage){
            Debug.Log("You have it");
            haspackage = false;
        }
        if (other.tag == "Package3" && !haspackage){
            Debug.Log("You picked up");
            haspackage = true;
            Destroy(other.gameObject);
        }
        if (other.tag == "Boost")
        {
            movespeed = boostspeed;
        }
        
    }
}


