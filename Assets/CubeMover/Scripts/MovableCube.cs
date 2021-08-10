using DG.Tweening;
using UnityEngine;

public class MovableCube : MonoBehaviour
{
    public void Init(int cubeMovingSpeed, int cubeMovingDistance)
    {
        var endPos = new Vector3(0, 0, cubeMovingDistance);
        transform.DOMove(endPos, cubeMovingSpeed).OnComplete(() =>
        {
            Destroy(gameObject);
        });
    }
}
