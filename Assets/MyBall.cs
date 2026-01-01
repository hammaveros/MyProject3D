using Unity.VisualScripting;
using UnityEngine;

public class MyBall : MonoBehaviour
{

    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        //rigidBody.linearVelocity = Vector3.right;
        //rigidBody.linearVelocity = new Vector3(2,4,3);
    }

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
        //rigidBody.AddTorque(Vector3.down);
    }

        
    private void OnTriggerStay(Collider other){
        if(other.name == "Cube")
            rigidBody.AddForce(Vector3.up * 15, ForceMode.Impulse);
            
    }
       
}
