using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class audiocontrol : MonoBehaviour {
    public AudioClip audioClip1;
    private AudioSource audioSource;
    // Use this for initialization
    void Start () {

        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
    }
	
	// Update is called once per frame
	void Update () {
        var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("トリガーを深く引いた");
            audioSource.Play();
        }
    }
}
