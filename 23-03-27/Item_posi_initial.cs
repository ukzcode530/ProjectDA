using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_posi_initial : MonoBehaviour
{
    private Vector3 originalPosition;
    private Transform capsuleColliderTransform;

    private void Awake()
    {
        capsuleColliderTransform = transform.parent;
    }

    void Start()
    {
        // 현재 객체의 위치 벡터를 반환
        originalPosition = transform.position;

        // 현재 객체의 위치를 화면에서 보이지 않는 곳으로 이동
        MoveToUnvisiblePosition();
    }

    public void MoveToUnvisiblePosition()
    {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(originalPosition);
        screenPosition.z = -1000f;
        transform.position = Camera.main.ScreenToWorldPoint(screenPosition);
    }

    public void MoveToOriginalPosition()
    {
        transform.SetParent(capsuleColliderTransform);
        transform.localPosition = Vector3.zero;
        transform.localPosition = new Vector3(0.551f, 0.425f, 1.829f);
    }
}
