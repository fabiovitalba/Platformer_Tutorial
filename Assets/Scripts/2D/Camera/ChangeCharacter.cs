using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CameraScrolling))]

public class ChangeCharacter : MonoBehaviour {

    private CameraScrolling cameraScrolling;

    public GameObject[] option;

    private Vector3 distance;

	// Use this for initialization
	void Start () {
        cameraScrolling = (CameraScrolling)GetComponent("CameraScrolling");
	}
	
	// Update is called once per frame
	void Update () {
        distance = option[0].transform.position - option[1].transform.position;
        if(Input.GetKeyDown(KeyCode.Return))    {
            if ((cameraScrolling.GetTarget().gameObject == option[0]) && (distance.sqrMagnitude < 10f))    //Enter the Spaceship
            {
                option[1].gameObject.SendMessage("SetControllable", true, SendMessageOptions.DontRequireReceiver);
                option[0].gameObject.SendMessage("SetControllable", false, SendMessageOptions.DontRequireReceiver);
                //option[0].gameObject.renderer.enabled = false;
                cameraScrolling.SetTarget(option[1].transform);
            }
            else   //Exit the Spaceship
            {
                option[0].gameObject.SendMessage("SetControllable", true, SendMessageOptions.DontRequireReceiver);
                option[1].gameObject.SendMessage("SetControllable", false, SendMessageOptions.DontRequireReceiver);
                //option[0].gameObject.renderer.enabled = true;
                cameraScrolling.SetTarget(option[0].transform);
            }
            
        }
	}
}
