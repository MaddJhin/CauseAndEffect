using UnityEngine;

public class DebugRay : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, gameObject.transform.right, 1000f, 1);

        Debug.DrawLine(gameObject.transform.position, hit.point);

    }
}
