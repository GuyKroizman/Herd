using UnityEngine;
using System.Collections;

public class InfectionController : MonoBehaviour {

    public Rigidbody target;

    public int moveSpeed;

    // Update is called once per frame
    void Update()
    {
        Vector3 directionTowardsPlayer;
        if (target.position.x > 3 && target.position.z > 3)
        {
            directionTowardsPlayer = (new Vector3(0, 0, 0) - transform.position).normalized;
        }
        else {
            directionTowardsPlayer = (target.position - transform.position).normalized;
        }

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(directionTowardsPlayer * moveSpeed * Time.deltaTime);
    }
}
