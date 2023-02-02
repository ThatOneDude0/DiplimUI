using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseClick : MonoBehaviour
{
    public GameObject particle;
    private Vector3 MousePos;

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray))
        //        Instantiate(particle, transform.position, transform.rotation);
        //}
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    MousePos = Input.mousePosition;
        //    Instantiate(particle, MousePos, transform.rotation);
        //}

        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);          

        //    if (Physics.Raycast(ray))
        //    {
        //        Instantiate(particle, transform.position, transform.rotation);                
        //    }
        //}

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Instantiate(particle, transform.position, transform.rotation);
            }
        }
    }
}
