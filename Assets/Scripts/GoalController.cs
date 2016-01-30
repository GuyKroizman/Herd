using UnityEngine;
using System.Collections;

public class GoalController : MonoBehaviour {
    
    private bool sheep1Arrived = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Sheep1")
        {
            sheep1Arrived = true;
        }

   
    }

    void OnCollisionExit(Collision collision)
    {

    }
}
