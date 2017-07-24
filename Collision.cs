using UnityEngine;

public class Collision : MonoBehaviour
{

    public Control movement;
    public bool onSomething;
    public Transform grounder;
    public float radius;
    public LayerMask ground;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        onSomething = Physics2D.OverlapCircle(grounder.transform.position, radius, ground);

        if (collisionInfo.gameObject.tag == "Platform" && onSomething == false)
        {
            movement.enabled = false;
        }
        else
        {
            movement.enabled = true;
        }
    }

}