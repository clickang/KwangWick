using UnityEngine;

public class PlayerVFXManager : MonoBehaviour
{
    /* 
     * [�÷��̾��� �ð� ȿ���� �����ϴ� ��ũ��Ʈ�Դϴ�.]
     * �ѱ� ȭ�� ȿ���� ����մϴ�.
     */

    #region Variables

    [field: SerializeField] public ParticleSystem MuzzleFlash { get; set; }

    #endregion

    #region User Methods

    // �ѱ� ȭ�� ȿ���� ����մϴ�.
    public void PlayMuzzleFlash()
    {
        if (MuzzleFlash != null)
        {
            MuzzleFlash.Play();
        }
    }

    #endregion

    #region Unity Methods

    public void Start()
    {
        if (MuzzleFlash == null)
        {
            MuzzleFlash = transform.GetComponentInChildren<ParticleSystem>();
        }
    }

    public void OnValidate()
    {
        if (MuzzleFlash == null)
        {
            MuzzleFlash = transform.GetComponentInChildren<ParticleSystem>();
        }
    }

    #endregion
}
