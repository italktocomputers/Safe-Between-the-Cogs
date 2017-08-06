using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour {
    public static float speed = 0.04f;
    public static float speedInSand = 0.01f;
    public static float swimSpeed = 0.02f;
    public static float speedOnSticky = 0.02f;
    public static float jumpHeightPower = 25.0f;
    public static float jumpHeightPowerInSand = 10.0f;
    public static float jumpHeightPowerInWater = 10.0f;
    public static float jumpHeightPowerOnSticky = 20.0f;
    public static AudioClip audioSplash;
    public static AudioClip audioSwim;
    public static AudioClip audioCoin;
    public static AudioClip audioHammer;

    public static void init() {
        audioSplash = Instantiate(Resources.Load("audio/water-splash", typeof(AudioClip))) as AudioClip;
        audioSwim = Instantiate(Resources.Load("audio/water-swim", typeof(AudioClip))) as AudioClip;
        audioCoin = Instantiate(Resources.Load("audio/coin", typeof(AudioClip))) as AudioClip;
        audioHammer = Instantiate(Resources.Load("audio/hammer", typeof(AudioClip))) as AudioClip;
    }
}
