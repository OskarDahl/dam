using UnityEngine;
using System.Collections;

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