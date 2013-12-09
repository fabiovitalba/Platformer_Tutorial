using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

    public GUIStyle MyStyle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        GUI.Box(new Rect(10, 10, 100, 40), "Score: " + GameData.Instance.Score, MyStyle);
    }
}
