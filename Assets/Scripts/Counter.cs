using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Counter : MonoBehaviour
{
    int points = 0;
    TextMeshProUGUI textmeshPro;
    public int GameLVL = 10;

    void Start()
    {
        textmeshPro = FindObjectOfType<TextMeshProUGUI>();
    }

    public void AddToCounter()
    {
        points++;
        textmeshPro.text = points.ToString();

        if (points == GameLVL)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
