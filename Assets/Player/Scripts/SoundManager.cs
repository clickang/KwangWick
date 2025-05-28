using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    /*
     * 사운드 관련 기능을 구현하는 스크립트입니다.
     */

    #region Variables

    [field: SerializeField, Header("Audio Settings")] public List<AudioSource> AudioSourceList { get; set; }

    #endregion

    #region User Methods

    // 총기 발사 소리를 재생합니다.
    public void GunFire()
    {
        AudioSourceList[0].PlayOneShot(AudioSourceList[0].clip);
    }

    #endregion
}
