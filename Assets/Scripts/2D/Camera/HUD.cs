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
        GUI.DrawTexture(new Rect(10, 10, 300, 100), texture);

        GUI.Box(new Rect(25, 25, 300, 80), "Score 00000000\n" + "Lives  00", GUIStyle);
    }
}
