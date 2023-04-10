using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector2 destination;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            collider.transform.position = destination;
        }
    }
}
