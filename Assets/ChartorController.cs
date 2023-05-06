using UnityEngine;

public class ChartorController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f; // �̵� �ӵ�
    private Vector3 moveDirection; // �̵� ����

    private CharacterController characterController; // ���� ���� 

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime); // �̵� * ����ӵ� * ��ŸŸ��
    }

    public void MoveTo(Vector3 direction) // MoveTo �Լ� �ܺο��� ȣ�� �Ű������� ���������� ��������
    {
        moveDirection = direction;
    }
}
