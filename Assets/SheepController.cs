using UnityEngine;
using System.Collections;

public class SheepController : MonoBehaviour {

    public Rigidbody Shepard;

    public int moveSpeed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 directionTowardsPlayer = (Shepard.position - transform.position).normalized;

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(directionTowardsPlayer * moveSpeed * Time.deltaTime);
    }
}
