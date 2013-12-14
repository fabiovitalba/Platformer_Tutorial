using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    public float turningSpeed;

    public bool xAxis;
    public bool yAxis;
    public bool zAxis;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(xAxis)    {
            transform.Rotate(Vector3.left * Time.deltaTime * turningSpeed);
        }
        if (yAxis)   {
            transform.Rotate(Vector3.up * Time.deltaTime * turningSpeed);
        }
        if (zAxis)   {
            transform.Rotate(Vector3.forward * Time.deltaTime * turningSpeed);
        }
	}
}
