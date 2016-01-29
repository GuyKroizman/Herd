using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject Shepard;

    private Vector3 offset;

	void Start () {
        offset = transform.position - Shepard.transform.position;
	}
	

	void LateUpdate () {
        transform.position = Shepard.transform.position + offset;
	}
}
