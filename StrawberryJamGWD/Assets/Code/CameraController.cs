using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform Player;

    public float 
        Margin,
        Smooth;
    public BoxCollider2D Bounds;
    private float
        minX,
        maxX,
        minY,
        maxY,
        camSize;

    public void Start()
    {
        minX = Bounds.offset.x - (Bounds.size.x/2f);
        maxX = Bounds.offset.x + (Bounds.size.x/2f);
        //minY = Bounds.offset.y - (Bounds.size.y/2f);
        //maxY = Bounds.offset.y + (Bounds.size.y/2f);
        camSize = GetComponent<Camera>().orthographicSize * GetComponent<Camera>().aspect-1f;
    }

    public void Update()
    {
        var x = transform.position.x;
        var y = Player.position.y+0.5f;
        if (Mathf.Abs(x - Player.position.x) > Margin)
            x = Mathf.Lerp(x, Player.position.x, Smooth * Time.deltaTime);
        x = Mathf.Clamp(x, minX + camSize, maxX - camSize);
        //y = Mathf.Clamp(y, minY + camSize, maxY - camSize);
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
