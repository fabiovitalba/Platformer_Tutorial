using UnityEngine;
using System.Collections;

public class collectibleFloat : MonoBehaviour {

    public float rotationSpeed;
    public GameObject collectiblePrefab;
    public int value;

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
            GameData.Instance.Score += value;
            Debug.Log("Score: " + GameData.Instance.Score);
            Destroy(gameObject);
        }
    }
}
