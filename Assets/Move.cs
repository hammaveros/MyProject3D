using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(20, 1.5f, 0);

    void Update()
    {
        /* MoveTowards 등속 이동 - 현재위치, 목표, 속도 */
        // transform.position =
        //     Vector3.MoveTowards(transform.position, target, 2f);

        /* SmoothDamp - 부드러운 감속 이동 */
        /* ref : 참조 접근 -> 실시간으로 바뀌는 값 적용 가능 */
        // Vector3 velo = Vector3.zero;
        // transform.position =
        //     Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        // /* Lerp - 선형 보간*/
        // transform.position =
        //     Vector3.Lerp(transform.position, target, 0.02f);

        /* Slerp - 구면 선형 보간, 호를 그리며 이동*/
        transform.position =
            Vector3.Slerp(transform.position, target, 0.02f);

    }

}

