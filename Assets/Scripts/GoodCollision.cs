using UnityEngine;
using UnityEngine.SceneManagement;

public class GoodCollision : MonoBehaviour
{
    Counter counter;
    AudioControll playaudio;

    void Start()
    {
        counter = GameObject.Find("BeerCounter").GetComponent<Counter>();
        playaudio = GameObject.Find("Audio Swallow").GetComponent<AudioControll>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            counter.AddToCounter();
            playaudio.PlayBeer();
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Box")
        {
            SceneManager.LoadScene("Fail");
        }
    }
}
