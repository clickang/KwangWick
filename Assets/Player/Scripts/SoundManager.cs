using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    /*
     * »ç¿îµå °ü·Ã ±â´ÉÀ» ±¸ÇöÇÏ´Â ½ºÅ©¸³Æ®ÀÔ´Ï´Ù.
     */

    #region Variables

    [field: SerializeField, Header("Audio Settings")] public List<AudioSource> AudioSourceList { get; set; }

    #endregion

    #region User Methods

    // ÃÑ±â ¹ß»ç ¼Ò¸®¸¦ Àç»ýÇÕ´Ï´Ù.
    public void GunFire()
    {
        if (AudioSourceList == null || AudioSourceList.Count == 0)
        {
            Debug.LogWarning("SoundManager: AudioSourceList가 비어 있음!");
            return;
        }

        if (AudioSourceList[0].clip == null)
        {
            Debug.LogWarning("SoundManager: AudioSourceList[0]에 클립이 없음!");
            return;
        }

        AudioSourceList[0].PlayOneShot(AudioSourceList[0].clip);
}


    #endregion
}
