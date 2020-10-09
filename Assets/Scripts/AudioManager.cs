using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GC_01()
    {
        AkSoundEngine.PostEvent("Play_Le_Grand_Coordinateur_01", gameObject);
    }

    void GC_02()
    {
        AkSoundEngine.PostEvent("Play_Le_Grand_Coordinateur_02", gameObject);
    }

    void GC_03()
    {
        AkSoundEngine.PostEvent("Play_Le_Grand_Coordinateur_03", gameObject);
    }

    void GC_04()
    {
        AkSoundEngine.PostEvent("Play_Le_Grand_Coordinateur_04", gameObject);
    }

    void GC_05()
    {
        AkSoundEngine.PostEvent("Play_Le_Grand_Coordinateur_05", gameObject);
    }

    void GC_06()
    {
        AkSoundEngine.PostEvent("Play_Le_Grand_Coordinateur_06", gameObject);
    }

    void GC_07()
    {
        AkSoundEngine.PostEvent("Play_Le_Grand_Coordinateur_07", gameObject);
    }

    void GC_08()
    {
        AkSoundEngine.PostEvent("Play_Le_Grand_Coordinateur_08", gameObject);
    }

    void GC_09()
    {
        AkSoundEngine.PostEvent("Play_Le_Grand_Coordinateur_09", gameObject);
    }

    void C_01()
    {
        AkSoundEngine.PostEvent("Play_Clorenthe_01", gameObject);
    }

    void C_02()
    {
        AkSoundEngine.PostEvent("Play_Clorenthe_02", gameObject);
    }

    void C_03()
    {
        AkSoundEngine.PostEvent("Play_Clorenthe_03", gameObject);
    }

    void C_04()
    {
        AkSoundEngine.PostEvent("Play_Clorenthe_04", gameObject);
    }

    void C_05()
    {
        AkSoundEngine.PostEvent("Play_Clorenthe_05", gameObject);
    }

    void Alerte()
    {
        AkSoundEngine.PostEvent("Play_SFX_Alarme", gameObject);
    }

    void AmbienceMachine()
    {
        AkSoundEngine.PostEvent("Stop_Ambiance_Monde_des_Robots", gameObject);
    }

    void PlaySnow()
    {
        AkSoundEngine.PostEvent("Play_White_Noise", gameObject);
    }

    void StopSnow()
    {
        AkSoundEngine.PostEvent("Stop_White_Noise", gameObject);
    }
}
