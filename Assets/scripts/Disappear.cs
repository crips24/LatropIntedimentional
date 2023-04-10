using UnityEngine;

public class Disappear : MonoBehaviour
{
    public static int count = 0; // Static variable to store the number of touched objects

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object has been touched
        if (collision.gameObject.tag == "Player")
        {
            // Increase the count and make the object disappear
            count++;
            gameObject.SetActive(false);
        }
    }
}
