using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform Player;

    public float 
        Margin,
        Smooth;

    public void Update()
    {
        var x = transform.position.x;
        var y = Player.position.y+0.5f;
        if (Mathf.Abs(x - Player.position.x) > Margin)
            x = Mathf.Lerp(x, Player.position.x, Smooth * Time.deltaTime);
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
