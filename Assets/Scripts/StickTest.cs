using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StickTest : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] private RectTransform rect_BackGround;
    [SerializeField] private RectTransform rect_joyStick;

    private float radius;

    [SerializeField] private GameObject Player;
    [SerializeField] private float moveSpeed;

    private bool isTouch = false;
    private Vector3 movePosition;
    void Start()
    {
        radius = rect_BackGround.rect.width * 0.5f;
    }

    void Update()
    {
        if (isTouch)
        {
            Player.transform.position += movePosition;
        }
    }


    public void OnDrag(PointerEventData eventData)
    {
        Vector2 value = eventData.position - (Vector2)rect_BackGround.position;

        value = Vector2.ClampMagnitude(value, radius);
        rect_joyStick.localPosition = value;

        value = value.normalized;
        movePosition = new Vector3(value.x * moveSpeed * Time.deltaTime, 0f, value.y * moveSpeed * Time.deltaTime);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isTouch = false;
        rect_joyStick.localPosition = Vector3.zero;
    }
}
