using UnityEngine;

public class Move : MonoBehaviour
{
    void Start()
    {
        //int number = 4; //scala
    }


    void Update()
    {
        // 증감
        // Vector3 vec = new Vector3(
        //     Input.GetAxis("Horizontal"),
        //     Input.GetAxis("Vertical")
        //     ,0); //vector

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            ,0); //vector
        
        transform.Translate(vec);   //이동 
    }
}

