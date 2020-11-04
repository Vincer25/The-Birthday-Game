using UnityEngine;

public class SpawnBeer : MonoBehaviour
{
    public GameObject Beer;
    float timeLeft = 1.2f;
    float halfWidth;
    float randomRange;

    void Start()
    {
        Camera camera = Camera.main;
        float halfHeight = camera.orthographicSize;
        halfWidth = camera.aspect * halfHeight;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        randomRange = Random.Range(-halfWidth + 0.5f, halfWidth - 0.5f);
        if (timeLeft < 0)
        {
            Instantiate(Beer, new Vector2(randomRange, 8f), Quaternion.identity);
            timeLeft = 1.5f;
        }
    }
}
