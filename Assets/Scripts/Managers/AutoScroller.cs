using UnityEngine;

public class AutoScroller : MonoBehaviour {

    public float scrollSpeed;

    private float tileSizeZ;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        tileSizeZ = GetComponent<RectTransform>().rect.height;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.up * newPosition;
    }
}
