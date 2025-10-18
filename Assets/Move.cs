using UnityEngine;

public class Move : MonoBehaviour
{
    void Update(){
        if (Input.anyKeyDown)
            Debug.Log("key 입력");

        if (Input.anyKey)
            Debug.Log("key 입력 진행");

        if (Input.GetKey(KeyCode.Return))
            Debug.Log("Enter");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽 이동");

        if (Input.GetKey(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동");
    }
}

