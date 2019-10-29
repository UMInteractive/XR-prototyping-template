using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    public GameObject cubeObject;
    public Transform selectedObject;
    public VrGrabber.VrgGrabber grabber;
    // Start is called before the first frame update
    void Start()
    {
        selectedObject = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (VrGrabber.VrgGrabber.hitObj.GetComponent<SphereChanger>()!=null)
        {
            
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.C))
            {
                selectedObject = VrGrabber.VrgGrabber.hitObj.GetComponent<SphereChanger>().nextSphereObject;
                VrGrabber.VrgGrabber.hitObj.GetComponent<SphereChanger>().ChangeSphere(selectedObject);
            }
        }


        
        
        
    }
}
