using UnityEngine;
using System.Collections;

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
            Color jeff = new Color(renderer.material.color.r - sickTendancy, 1f, renderer.material.color.b - sickTendancy);
            renderer.material.color = jeff;
        }
    }
}
