using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject Shepard;

    private Vector3 offset;

    void Start () {
        offset = transform.position - Shepard.transform.position;

        GameObject t = GameObject.Find("Goal");
        
	}

    void LateUpdate () {
        if(Shepard.transform.position.x > 3f && 
            Shepard.transform.position.z > 3f)
        {
            return;
        }
        transform.position = Shepard.transform.position + offset;
	}
}
