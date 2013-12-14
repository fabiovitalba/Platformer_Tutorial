using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

    public GUIStyle GUIStyle;
    public Texture texture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        GUI.Box(new Rect(10, 10, 350, 40), "Score: 00000000", GUIStyle);
    }
}
