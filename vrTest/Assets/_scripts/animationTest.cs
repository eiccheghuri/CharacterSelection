using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class animationTest : MonoBehaviour
{

    public GameObject Targt;

    private Transform target_transform;

    public void Awake()
    {
        target_transform = Targt.GetComponent<Transform>();
    }

   


    public void FixedUpdate()
    {
        // dotwenDomove();

      //  dotweenDomoveY();

    }

    public void dotwenDomove()
    {
        Targt.transform.DOMove(new Vector2(15f, target_transform.position.y), 0.25f,true);

    }

    public void dotweenDomoveY()
    {

        Targt.transform.DOMoveY(10f,1f);


    }

    public void jumpingDotween()
    {
        Targt.transform.DOJump(new Vector2(0f,0f),10f,2,1f);
    }








}
