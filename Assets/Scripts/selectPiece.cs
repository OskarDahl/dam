using UnityEngine;
using System.Collections;

public class selectPiece : MonoBehaviour {

	bool green = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButton("Fire1"))
        {
			if (green == false)
			{
				show();
				green = true;
			}
			else
			{
				hide();
			}
        }
	}
}
