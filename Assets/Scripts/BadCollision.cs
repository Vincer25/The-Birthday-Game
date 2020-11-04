using UnityEngine;
using UnityEngine.SceneManagement;

public class BadCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Fail");
        }
        else if (collision.gameObject.name == "Box")
        {
            Destroy(gameObject);
        }
    }
}
