using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerManager : MonoBehaviour
{
    /*
     * 플레이어 전반에 관한 스크립트입니다.
     */

    #region Variables

    [Tooltip("컴포넌트")]
    [field: SerializeField, Header("Components")] public PlayerInfo PlayerInfo { get; set; }
    [field: SerializeField] public PlayerInput PlayerInput { get; set; }
    [field: SerializeField] public CharacterController CharacterController { get; set; }
    [field: SerializeField] public FirstPersonCameraController CameraController { get; set; }
    [field: SerializeField] public Camera PlayerCamera { get; set; }

    #endregion

    #region Unity Methods

    public void Start()
    {
        PlayerInfo = GetComponent<PlayerInfo>();
        PlayerInput = GetComponent<PlayerInput>();
        CharacterController = GetComponent<CharacterController>();
        CameraController = GetComponent<FirstPersonCameraController>();
        PlayerCamera = GetComponentInChildren<Camera>();
    }

    #endregion
}
