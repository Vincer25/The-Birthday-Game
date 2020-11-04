using UnityEngine;

public class CounterOverwrite : MonoBehaviour
{
    Counter counter;
    private void Start()
    {
        counter = GetComponent<Counter>();
        counter.GameLVL = 30;
    }
}
