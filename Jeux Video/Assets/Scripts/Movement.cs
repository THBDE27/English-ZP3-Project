using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] GameObject perso;
    [SerializeField] float swimSpeed;
    [SerializeField] Animator anim;
    [SerializeField] Camera cam;

    CharacterController characControl;

    Vector2 move = Vector2.zero;
    Quaternion rotationOriginal;


    void Start()
    {
        characControl = GetComponent<CharacterController>();
        rotationOriginal = perso.transform.rotation;
    }

    void Update()
    {
        Nage();
    }

    private void Nage()
    {
        Vector3 direction = perso.transform.forward * move.y;

        if (move.y > 0)
        {
            perso.transform.rotation = rotationOriginal;
            cam.transform.rotation = rotationOriginal * Quaternion.Euler(90, 0, 0);
            direction = perso.transform.forward * move.y;
        }

        if (move.y < 0)
        {
            perso.transform.rotation = rotationOriginal * Quaternion.Euler(0, 180, 0);
            cam.transform.rotation = rotationOriginal * Quaternion.Euler(90, 0, 0);
            direction = -perso.transform.forward * move.y;
        }  

        if(characControl != null && Time.timeScale != 0)
        {
            characControl.Move(direction * swimSpeed * Time.deltaTime);
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
        anim.SetBool("isSwimming", move.magnitude > 0.1f);
    }
}
