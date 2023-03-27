using UnityEngine;

public class CurruntposiCheck : MonoBehaviour
{
    void Start()
    {
        Vector3 currentPosition = transform.position;
        Debug.Log("Current position: " + currentPosition);
    }
}