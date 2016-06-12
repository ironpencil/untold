using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = newPos;
	
	}
}
