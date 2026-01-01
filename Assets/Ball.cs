using UnityEngine;

public class Ball : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Material material;
    void Start()
    {   
        meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.material;
        
    }

    //물리적 충돌이 시작될 때 
    private void OnCollisionEnter(Collision collision){
        //충돌정보 클래스
        if(collision.gameObject.name != "Floor"){
            material.color = new Color(1,1,1);
        }

    }

    //충돌 지속
    private void OnCollisionStay(Collision collision){}

    //충돌 끝
    private void OnCollisionExit(Collision collision){
        //충돌정보 클래스
        if(collision.gameObject.name != "Floor"){
            material.color = new Color(0,0,0);
        }
    }
}
