using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class DeathDoTween : MonoBehaviour
{
    [SerializeField] Transform death;
    [SerializeField] Camera cam;

    void OnEnable()
    {
         cam.DOShakePosition(0.3f).OnStart(() =>
         {
             death.DOLocalRotate(Vector3.forward * -10f, .2f);

             death.DOScale(Vector3.one * 3f, .3f);
         });
    }
}
