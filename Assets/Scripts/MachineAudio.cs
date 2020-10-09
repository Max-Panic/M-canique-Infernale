using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineAudio : MonoBehaviour
{
    public AK.Wwise.Event Bottle_Appearance;
    public AK.Wwise.Event Sleeping_Hamster;
    public AK.Wwise.Event Running_Hamster_Starting;
    public AK.Wwise.Event Stop_Sleeping_Hamster;
    public AK.Wwise.Event Stop_Running_Hamster_Wheel;
    public AK.Wwise.Event Play_Motor_Activation;
    public AK.Wwise.Event Stop_Machine_Infernale;
    public AK.Wwise.Event Play_Fire;
    public AK.Wwise.Event Play_Pneumatic;
    public AK.Wwise.Event Play_Mechanical_Arm;
    public AK.Wwise.Event Play_Pince;


    public void BottleAppearance()
    {
        Bottle_Appearance.Post(gameObject);
    }

    public void SleepingHamster()
    {
        Sleeping_Hamster.Post(gameObject);
    }

    public void RunningHamsterStarting()
    {
        Running_Hamster_Starting.Post(gameObject);
    }

    public void StopSleepingHamster()
    {
        Stop_Sleeping_Hamster.Post(gameObject);
    }

    public void StopRunningHamsterWheel()
    {
        Stop_Running_Hamster_Wheel.Post(gameObject);
    }

    public void PlayMotorActivation()
    {
        Play_Motor_Activation.Post(gameObject);
    }

    public void StopMachineInfernale()
    {
       Stop_Machine_Infernale.Post(gameObject);
    }

    public void PlayFire()
    {
        Play_Fire.Post(gameObject);
    }

    public void PlayPneumatic()
    {
        Play_Pneumatic.Post(gameObject);
    }

    public void PlayMechanicalArm()
    {
        Play_Mechanical_Arm.Post(gameObject);
    }

    public void PlayPince()
    {
       Play_Pince.Post(gameObject);
    }
}
