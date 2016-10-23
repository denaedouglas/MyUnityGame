using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    private KeyCode jump;
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(jump))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            
        }
    }
}
