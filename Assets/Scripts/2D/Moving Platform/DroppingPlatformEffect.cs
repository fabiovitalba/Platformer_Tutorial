using UnityEngine;
using System.Collections;

public class DroppingPlatformEffect : MonoBehaviour {

    public float droppingSpeed;
    public float maxAngleToTurn;
    public float turningSpeed;

    enum Phase
    {
        Untouched,
        Turning,
        Dropping
    }

    private Phase platformPhase;

	// Use this for initialization
	void Start () {
        platformPhase = Phase.Untouched;
	}
	
	// Update is called once per frame
	void Update () {
        if (platformPhase != Phase.Untouched)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * turningSpeed);

            if (transform.rotation.z > 30f)   {
                platformPhase = Phase.Dropping;
            }
        }
        if (platformPhase == Phase.Dropping)  {
            float amtToMove = droppingSpeed * Time.deltaTime;

            transform.Translate(Vector3.down * amtToMove, Space.World);

        }
        else {

        }
	}

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Player")
        {
            new WaitForSeconds(2f);
            platformPhase = Phase.Turning;
        }
    }
}
