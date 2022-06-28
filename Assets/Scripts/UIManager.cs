using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public void MoveHoriaontal(RectTransform panel)
    {
        Sequence seq = DOTween.Sequence();

        switch (panel.anchoredPosition.x)
        {
            case 0f:
                seq.Append(panel.DOAnchorPosX(panel.sizeDelta.x, 1f));
                break;
            case 200f:
                seq.Append(panel.DOAnchorPosX(0f, 1f));
                break;
            default:
                break;
        }
    }
}
