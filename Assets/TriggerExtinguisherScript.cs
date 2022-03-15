using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TriggerExtinguisherScript : MonoBehaviour
{
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireRayCast();
        }
    }
    void FireRayCast()
    {
        Ray ray = cam.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10000))
        {
            Debug.Log(hit.transform.gameObject.name);
        }
    }
}
