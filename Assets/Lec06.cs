using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lec06 : MonoBehaviour
{
    // Start is called before the first frame update 초기인자값
    void Start()
    {
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

    }
    

    // Update is called once per frame 계속 반복되는 값

}


    //클래스(class) 
      //-> 메서드(method): 함수
        //->조건문, 제어문, 반복문