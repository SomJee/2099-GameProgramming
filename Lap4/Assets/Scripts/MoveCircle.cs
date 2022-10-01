using UnityEngine;
using DG.Tweening;

public class MoveCircle : MonoBehaviour
{
  [SerializeField] private Transform tweenEndPoint;
  void Start()
  {
    transform.DOMove(tweenEndPoint.position, 5f).SetEase(Ease.InOutQuad).SetLoops(-1, LoopType.Yoyo);
  }
}
