using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(FirstPersonCameraController))]
public class PlayerInput : MonoBehaviour
{
    /*
     * 플레이어의 입력을 처리하는 스크립트입니다.
     */

    #region Variables

    [Tooltip("컴포넌트")]
    [field: SerializeField, Header("Components")] FirstPersonCameraController CameraController { get; set; }
    [field: SerializeField] Animator Animator { get; set; }

    #endregion

    #region Input Handlers

    public void OnLook(InputValue value)
    {
        CameraController.LookInput = value.Get<Vector2>();
    }

    public void OnAttack()
    {
        Animator.SetTrigger("Fire");
    }

    public void OnLeanLeft(InputValue value)
    {
        CameraController.LeanLeftToggle = value.Get<float>();
    }

    public void OnLeanRight(InputValue value)
    {
        CameraController.LeanRightToggle = value.Get<float>();
    }

    #endregion

    #region Unity Methods

    public void Awake()
    {
        if(CameraController == null)
        {
            CameraController = GetComponent<FirstPersonCameraController>();
        }
        if(Animator == null)
        {
            Animator = GetComponentInChildren<Animator>();
        }
    }

    public void OnValidate()
    {
        if (CameraController == null)
        {
            CameraController = GetComponent<FirstPersonCameraController>();
        }
        if (Animator == null)
        {
            Animator = GetComponentInChildren<Animator>();
        }
    }

    #endregion
}
