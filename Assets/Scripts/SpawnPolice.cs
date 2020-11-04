using UnityEngine;

public class SpawnPolice : MonoBehaviour
{
    public GameObject Police;
    float timeLeft = 3f;
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
            Instantiate(Police, new Vector2(randomRange, 8f), Quaternion.Euler(0, 0, 90));
            timeLeft = 1.8f;
        }
    }
}