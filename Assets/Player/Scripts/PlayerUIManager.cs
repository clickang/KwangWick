using UnityEngine;
using System.Collections;

public class PlayerUIManager : MonoBehaviour
{
    /* 
     * [�÷��̾� UI�� �����ϴ� ��ũ��Ʈ�Դϴ�.]
     * �÷��̾��� UI ��ҵ��� Ȱ��ȭ�ϰų� ��Ȱ��ȭ�մϴ�.
     */

    #region Variables

    [field: SerializeField] public GameObject HitBody { get; set; }
    [field: SerializeField] public GameObject HitHead { get; set; }
    [field: SerializeField] public GameObject HitKill { get; set; }

    #endregion

    #region User Methods

    // Ÿ���� �¾��� �� UI�� ����մϴ�.
    public void ToggleHitUI(int hitType)
    {
        switch (hitType)
        {
            case 1: // HitType.Body
                StartCoroutine(ShowAndHideHitUI(HitBody));
                break;
            case 2: // HitType.Head
                StartCoroutine(ShowAndHideHitUI(HitHead));
                break;
            case 3: // HitType.Kill
                StartCoroutine(ShowAndHideHitUI(HitKill));
                break;
            default: // HitType.None
                break;
        }
    }

    // UI�� �����ְ� ����� �ڷ�ƾ�Դϴ�.
    IEnumerator ShowAndHideHitUI(GameObject hitUI, float duration = 0.2f)
    {
        hitUI.SetActive(true);
        yield return new WaitForSeconds(duration);
        hitUI.SetActive(false);
    }

    #endregion

    #region Unity Methods

    public void Start()
    {
        if (HitBody == null)
        {
            HitBody = transform.Find("HitMarker/Body").gameObject;
        }
        if (HitHead == null)
        {
            HitHead = transform.Find("HitMarker/Head").gameObject;
        }
        if (HitKill == null)
        {
            HitKill = transform.Find("HitMarker/Kill").gameObject;
        }
    }

    public void OnValidate()
    {
        if (HitBody == null)
        {
            HitBody = transform.Find("HitMarker/Body").gameObject;
        }
        if (HitHead == null)
        {
            HitHead = transform.Find("HitMarker/Head").gameObject;
        }
        if (HitKill == null)
        {
            HitKill = transform.Find("HitMarker/Kill").gameObject;
        }
    }

    #endregion
}
