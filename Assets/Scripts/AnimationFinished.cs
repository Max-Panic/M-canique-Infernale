using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFinished : MonoBehaviour
{
    private Animator truc;
    
    // Start is called before the first frame update
    void Start()
    {
        truc = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KeyFinish()
    {
        truc.SetBool("KeyFinished",true);
    }

    public void WaterFinish()
    {
        truc.SetBool("WaterFinished", true);
    }
}
