using UnityEngine;
using System.Collections;

public class DoorPhysics : MonoBehaviour {

    // F=μFN 
    // Use this for initialization
    [Header("简谐运动方程")]
    [Header("角速度")]
    public float omega = 0.2f;
    public float A = 0.5f;
    public float dt = 0;
    public float phine = 20f;
    

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float angle = A * Mathf.Cos(omega * dt + phine);
        transform.eulerAngles = new Vector3(0,angle,0);
        Debug.Log(angle);
        dt++;

	}
}
