using UnityEngine;
using System.Collections;

public class CollectibleAttributes : MonoBehaviour {

    public int value;
    public GameObject ExplosionPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider otherObject) {
        if (otherObject.tag == "Player") {

            //GameData.Instance.Score += value;
            //Debug.Log("Score: " + GameData.Instance.Score);

            Instantiate(ExplosionPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            Destroy(gameObject);
        }
    }
}
