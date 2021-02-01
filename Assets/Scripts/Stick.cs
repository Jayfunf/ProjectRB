using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Stick : MonoBehaviour//, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
   /* RectTransform background_Rect;
    [SerializeField] RectTransform joystick_Rect;
    [SerializeField] Transform player;
    Vector3 pos;
    float range;
    bool touchFlag = false;

    void Start()
    {
        background_Rect = gameObject.GetComponent<RectTransform>();
        range = background_Rect.rect.width * 0.5f;
    }

    void Update()
    {
        if (touchFlag)
        {
            player.position += pos.normalized * Time.deltaTime;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        pos = new Vector3(eventData.position.x - (background_Rect.position.x), eventData.position.y - (background_Rect.position.y),0);
        pos = Vector3.ClampMagnitude(pos, range);
        joystick_Rect.localPosition = pos;
        player.eulerAngles = new Vector3(0, 0, (Mathf.Atan2(pos.normalized.y, pos.normalized.x) * Mathf.Rad2Deg - 90));
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        touchFlag = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        touchFlag = false;
        joystick_Rect.localPosition = Vector3.zero;
    }

    */
}
