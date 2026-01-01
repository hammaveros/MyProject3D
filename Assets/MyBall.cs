using UnityEngine;

public class MyBall : MonoBehaviour
{

    //코드 흐름은 선언 > 초기화 > 호출
    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        //rigidBody.linearVelocity = Vector3.right;
        //rigidBody.linearVelocity = new Vector3(2,4,3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rigidBody.linearVelocity = new Vector3(2,4,3);
        if (Input.GetButtonDown("Jump"))
        {
            rigidBody.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rigidBody.linearVelocity);
        }


        // 이동하기
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal")
            , 0
            ,Input.GetAxisRaw("Vertical"));

        rigidBody.AddForce(vec, ForceMode.Impulse);

        // 회전력
        rigidBody.AddTorque(Vector3.down);
       
    }
}
