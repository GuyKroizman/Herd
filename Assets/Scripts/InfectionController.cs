using UnityEngine;
using System.Collections;

public class InfectionController : MonoBehaviour {

    public Rigidbody target;

    public int moveSpeed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionTowardsPlayer = (target.position - transform.position).normalized;

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(directionTowardsPlayer * moveSpeed * Time.deltaTime);
    }
}
