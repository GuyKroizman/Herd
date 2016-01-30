using UnityEngine;
using System.Collections;
using System;

public class SheepController : MonoBehaviour {

    public Rigidbody Shepard;

    public int moveSpeed;

    public float sickTendancy;

    // Update is called once per frame
    void Update () {
        Vector3 directionTowardsPlayer = (Shepard.position - transform.position).normalized;

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(directionTowardsPlayer * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Infection1")
        {
            Renderer renderer = GetComponent<Renderer>();
			float newColorFloat = Math.Max(0f, renderer.material.color.r - sickTendancy);
			Color jeff = new Color(newColorFloat, 1f, newColorFloat);
            renderer.material.color = jeff;
        }
    }
}
