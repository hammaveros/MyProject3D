using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    void Awake(){
        // (초기화) 최초 실행
        Debug.Log("awake");  
    }

    void OnEnable(){
        //(활성화)
        Debug.Log("onEnable");  
    }

    void Start(){
        // (초기화) 업데이트 시작 직전 최초 실행
        Debug.Log("start");  
    }

    void FixedUpdate(){
        // (물리 연산) 업데이트 
        //고정된 실행 주기로 cpu를 많이 사용 (초당 50회)
        Debug.Log("fixedUpdate");                
    }

    void Update(){
        // (게임 로직) 업데이트
        // 환경에 따라 실행 주기가 떨어 질 수 있음
        Debug.Log("update");
    }

    void LateUpdate(){
        // (게임 로직) 모든 업데이트가 끝난후
        Debug.Log("lateUpdate");
    }

    void OnDisable(){
        //(비활성화)
        Debug.Log("onDisable");  
    }

    void OnDestroy(){
        // (해체) 게임 오브젝트가 삭제 될 때
        Debug.Log("onDestroy");
    }
}
