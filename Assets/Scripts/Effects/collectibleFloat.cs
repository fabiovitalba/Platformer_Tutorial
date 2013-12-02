using UnityEngine;
using System.Collections;

public class collectibleFloat : MonoBehaviour {

    public float rotationSpeed;
    public GameObject collectiblePrefab;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        float amtToRotate = rotationSpeed * Time.deltaTime;

        transform.Rotate(new Vector3(0, 0, amtToRotate));
	}

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Player")
        {
            //Debug.Log("This Object collided: " + otherObject.tag);
            Destroy(gameObject);
        }
    }
}
