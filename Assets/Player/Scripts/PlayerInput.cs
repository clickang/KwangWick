using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(FirstPersonCameraController))]
public class PlayerInput : MonoBehaviour
{
    /*
     * [플레이어의 입력을 처리하는 스크립트입니다.]
     * 하드웨어 입력이 들어오면 적절하게 변환하여 필요한 함수로 전달합니다.
     */

    #region Variables

    [Tooltip("컴포넌트")]
    [field: SerializeField, Header("Components")] FirstPersonCameraController CameraController { get; set; }
    [field: SerializeField] Animator Animator { get; set; }
    [field: SerializeField] SoundManager SoundManager { get; set; }

    #endregion

    #region Input Handlers

    // 마우스 움직임을 처리합니다.
    public void OnLook(InputValue value)
    {
        CameraController.LookInput = value.Get<Vector2>();
    }

    // 마우스 왼쪽 버튼을 처리합니다.
    public void OnAttack()
    {
        Animator.SetTrigger("Fire");
        SoundManager.GunFire();
        CameraController.ApplyRecoil();
    }

    // Q 버튼을 처리합니다.
    public void OnLeanLeft(InputValue value)
    {
        CameraController.LeanLeftToggle = value.Get<float>();
    }

    // E 버튼을 처리합니다.
    public void OnLeanRight(InputValue value)
    {
        CameraController.LeanRightToggle = value.Get<float>();
    }

    #endregion

    #region Unity Methods

    public void Start()
    {
        if(CameraController == null)
        {
            CameraController = GetComponent<FirstPersonCameraController>();
        }
        if(Animator == null)
        {
            Animator = GetComponentInChildren<Animator>();
        }
        if(SoundManager == null)
        {
            SoundManager = GetComponentInChildren<SoundManager>();
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
        if (SoundManager == null)
        {
            SoundManager = GetComponentInChildren<SoundManager>();
        }
    }

    #endregion
}
