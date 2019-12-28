using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UiManager : MonoBehaviour
{
    public RectTransform menu_1, menu_2, menu_3;

    public void Start()
    {
        menu_1.DOAnchorPos(Vector2.zero,.25f);
    }

    public void buttonClicked()
    {
        menu_1.DOAnchorPos(new Vector2(-2000f, 0f), 0.25f);
        menu_2.DOAnchorPos(Vector2.zero,0.25f);
    }
    public void Button2Clicked()
    {

        menu_2.DOAnchorPos(new Vector2(2000f,0f), 0.25f);
        menu_1.DOAnchorPos(Vector2.zero, .25f);

    }







}// uiManager class
