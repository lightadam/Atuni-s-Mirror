
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform player;
    public Vector3 rightCamera;
    public Vector3 leftCamera;
    public Vector3 offset;
   
	void Update () {
        transform.position = player.position + offset;
        if (Input.GetKey("d"))
        {
            transform.position = player.position + rightCamera;
        }
         else if (Input.GetKey("a")) {
            transform.position = player.position  + leftCamera;
        }
    }
}
