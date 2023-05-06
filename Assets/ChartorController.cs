using UnityEngine;

public class ChartorController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f; // 이동 속도
    private Vector3 moveDirection; // 이동 방향

    private CharacterController characterController; // 변수 선언 

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime); // 이동 * 방향속도 * 델타타임
    }

    public void MoveTo(Vector3 direction) // MoveTo 함수 외부에서 호출 매개변수의 방향정보를 가져오기
    {
        moveDirection = direction;
    }
}
