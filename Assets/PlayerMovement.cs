using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Animator animator;
    public RobotControls playerControls;
    public float speed = 2f;
    public float rot;
    public TMP_Text speedText;
    public TMP_Text coordText;
    public TMP_Text rotText;
    private InputAction move;
    private Vector3 moveDirection = Vector3.zero;
    private bool isMoving = false;
    private void Start()
    {
        coordText.text = "Координаты: " + rb.position.ToString("F2");
        rotText.text = "Угол поворота: " + transform.eulerAngles.y.ToString("F2");
    }
    private void Awake()
    {
        playerControls = new RobotControls();
    }
    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();
    }
    private void OnDisable()
    {
        move.Disable();
    }
    void Update()
    {
        Vector3 input = move.ReadValue<Vector3>();
        moveDirection = new Vector3(input.x, 0, input.z);
        bool currentlyMoving = moveDirection != Vector3.zero;
        if (currentlyMoving != isMoving)
        {
            isMoving = currentlyMoving;
            animator.SetBool("isMoving", isMoving);
            if (isMoving == true)
            {
                speedText.text = "Скорость робота: " + speed;
            }
            else
            {
                speedText.text = "Скорость робота: 0";
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 movement = moveDirection * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
        if (moveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rot * Time.deltaTime);
        }
        coordText.text = "Координаты: " + rb.position.ToString("F2");
        rotText.text = "Угол поворота: " + transform.eulerAngles.y.ToString("F2");
    }
}
