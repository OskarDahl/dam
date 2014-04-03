using UnityEngine;
using System.Collections;

public class showGreen : MonoBehaviour {
    bool sh = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            if (sh == false)
            {
                gameObject.SetActive(true);
                sh = true;
            }
            if (sh == true)
            {
                gameObject.SetActive(false);
                sh = false;
            }

        }
		
	}

}
