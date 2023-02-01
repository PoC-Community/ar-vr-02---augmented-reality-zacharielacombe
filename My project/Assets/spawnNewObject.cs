using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject spawnable;
    public ARRaycastManager RayCastManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            List<ARRaycastHit> touches = new List<ARRaycastHit>();
            RayCastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
            if (touches.Count > 0)
                GameObject.Instantiate(spawnable, touches[0].pose.position, touches[0].pose.rotation);
        }
    }
}