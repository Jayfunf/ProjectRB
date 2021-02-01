using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Invisible")
        {
            //rgb 설정 or 마따리얼 수정
            //git을 위한 수정
        }
    }
}
