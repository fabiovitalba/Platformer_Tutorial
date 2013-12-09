using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float Speed;
    public float bumpSpeed; //How fast are you bumped up if jumped
    public bool invincible; //Well... You know... Dark Souls and stuff...

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //With the rigidbody it starts rolling.
        rigidbody.velocity = new Vector3(Speed, rigidbody.velocity.y, rigidbody.velocity.z);
	}

    void OnCollisionEnter(Collision collision)  {
        if (collision.gameObject.name.Contains("Platform - End Cap") || collision.gameObject.name.Contains("Boundary") || collision.gameObject.name.Contains("Crate"))
        {
            Speed *= -1;
        }
    }

    public void Kill() {
        //Falls down
        collider.enabled = false;
    }
}
