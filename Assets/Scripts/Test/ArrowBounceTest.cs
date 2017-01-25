using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBounceTest : MonoBehaviour {

    public GameObject rayOrigin; 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit2D hit = Physics2D.Raycast(rayOrigin.transform.position, rayOrigin.transform.right, Mathf.Infinity, 1);

        if (hit)
        {
            //Debug.DrawLine(rayOrigin.transform.position, hit.point);
            DeflectDraw(hit);
        }
        else
        {
            Debug.DrawLine(rayOrigin.transform.position, rayOrigin.transform.right * 1000);
        }

    }

    void FirstDraw()
    {
        Ray2D a = new Ray2D(rayOrigin.transform.position, rayOrigin.transform.right);
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin.transform.position, rayOrigin.transform.right, 1000f, 1);
    }

    void DeflectDraw(RaycastHit2D hit)
    {
        RaycastHit2D hit2 = Physics2D.Raycast(hit.point, hit.point.normalized, Mathf.Infinity, 1);

        Vector2 origin = new Vector2(rayOrigin.transform.position.x, rayOrigin.transform.position.y);
        Vector3 dirrection = (hit.point - origin).normalized;

        Vector3 reflectedVector = Vector3.Reflect(dirrection, hit.normal);

        //Debug.DrawLine(hit.point, reflectedVector * 1000);

        Debug.DrawRay(hit.point, reflectedVector);

        if (hit2)
        {
            
        }
        else
        {
            Debug.DrawLine(rayOrigin.transform.position, rayOrigin.transform.right * 1000);
        }
    }
}
