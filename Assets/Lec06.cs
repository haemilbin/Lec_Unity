using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lec06 : MonoBehaviour
{
    // Start is called before the first frame update 초기인자값
    void Start()
    {
        int [ ] score = {100, 50, 80, 90, 95};

        score[1] = 70;

        for (int index = 0; index < 5; index++)
        {
            Debug.Log (score[index]);
        }
    }

    // Update is called once per frame 계속 반복되는 값
    void Update()
    {
        
    }
}
