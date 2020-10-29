using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class SwipeFocal : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private float fingerDown;
    private float fingerUp;
	public Camera cam;

    public bool detectSwipeOnlyAfterRelease = false;
	public float swipy;

			
			public void OnBeginDrag(PointerEventData eventData)
			{
                fingerUp = eventData.position.y;
            }

            //Detects Swipe while finger is still moving
            public void OnDrag(PointerEventData data)
            {
                if (!detectSwipeOnlyAfterRelease)
                {
                    fingerDown = data.position.y;
                    checkSwipe();
                }
            }

            //Detects swipe after finger is released
            public void OnEndDrag(PointerEventData eventData)
			{
                fingerDown = eventData.position.y;
                checkSwipe();
				swipy = 0;
				fingerUp = 0;
                fingerDown = 0;
            }


    void checkSwipe()
    {
        
            if (fingerDown > 0)//up swipe
            {
				swipy = fingerDown - fingerUp;
				cam.focalLength += swipy;
            }
            else if (fingerDown < 0)//Down swipe
            {
                 swipy = fingerDown - fingerUp;
				cam.focalLength -= swipy;
			}
			cam.focalLength = Mathf.Clamp(cam.focalLength,10,500);
			fingerUp = fingerDown;

    }

}
