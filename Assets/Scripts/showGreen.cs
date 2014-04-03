using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public class showGreen : MonoBehaviour
{

    bool sh = false;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (sh == true)
            {
                renderer.enabled = false;
                //gameObject.SetActive(false);
                sh = false;
                System.Threading.Thread.Sleep(200);
            }
            else if (sh == false)
            {
                renderer.enabled = true;
                //gameObject.SetActive(true);
                sh = true;
                System.Threading.Thread.Sleep(200);
            }
        }

    }

}
=======
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
>>>>>>> f3f2900c9e50ebd6b47d5937b9b359daa2430f96
