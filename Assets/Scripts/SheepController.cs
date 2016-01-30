using UnityEngine;
using System.Collections;
using System;

public class SheepController : MonoBehaviour {

    public Rigidbody Shepard;

    public int moveSpeed;

    public float sickTendancy;

	public AudioSource cough1;
	public AudioSource cough2;

	public AudioSource abba1;
	public AudioSource abba2;


	private int intervals = 0;

    // Update is called once per frame
    void Update () {
        Vector3 directionTowardsPlayer = (Shepard.position - transform.position).normalized;

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(directionTowardsPlayer * moveSpeed * Time.deltaTime);


		intervals++;
		if (intervals % 100 == 0) {
			if (UnityEngine.Random.value > 0.85) {
				if (UnityEngine.Random.value > 0.5) 
					abba1.Play();
				else
					abba2.Play();
			}

		}
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Infection1")
        {
            Renderer renderer = GetComponent<Renderer>();
			float newColorFloat = Math.Max(0f, renderer.material.color.r - sickTendancy);
			Color jeff = new Color(newColorFloat, 1f, newColorFloat);
            renderer.material.color = jeff;

			if (UnityEngine.Random.value > 0.5) 
				cough1.Play();
			else
				cough2.Play();

        }
    }
}
