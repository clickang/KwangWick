using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(FirstPersonCameraController))]
public class PlayerInput : MonoBehaviour
{
    /*
     * [ÇÃ·¹ÀÌ¾îÀÇ ÀÔ·ÂÀ» Ã³¸®ÇÏ´Â ½ºÅ©¸³Æ®ÀÔ´Ï´Ù.]
     * ÇÏµå¿þ¾î ÀÔ·ÂÀÌ µé¾î¿À¸é ÀûÀýÇÏ°Ô º¯È¯ÇÏ¿© ÇÊ¿äÇÑ ÇÔ¼ö·Î Àü´ÞÇÕ´Ï´Ù.
     */

    #region Variables

    [Tooltip("ÄÄÆ÷³ÍÆ®")]
    [field: SerializeField, Header("Components")] FirstPersonCameraController CameraController { get; set; }
    [field: SerializeField] Animator Animator { get; set; }
    [field: SerializeField] SoundManager SoundManager { get; set; }
    [field: SerializeField] Gun Gun { get; set; }

    #endregion

    #region Input Handlers

    // ¸¶¿ì½º ¿òÁ÷ÀÓÀ» Ã³¸®ÇÕ´Ï´Ù.
    public void OnLook(InputValue value)
    {
        CameraController.LookInput = value.Get<Vector2>();
    }

    // ¸¶¿ì½º ¿ÞÂÊ ¹öÆ°À» Ã³¸®ÇÕ´Ï´Ù.
    public void OnAttack()
    {
        Animator.SetTrigger("Fire");
        SoundManager.GunFire();
        CameraController.ApplyRecoil();

        if (Gun != null)
        {
            Gun.Shoot();
        }
    }

    // Q ¹öÆ°À» Ã³¸®ÇÕ´Ï´Ù.
    public void OnLeanLeft(InputValue value)
    {
        CameraController.LeanLeftToggle = value.Get<float>();
    }

    // E ¹öÆ°À» Ã³¸®ÇÕ´Ï´Ù.
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
        if(Gun == null)
        {
            Gun = GetComponentInChildren<Gun>();
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
