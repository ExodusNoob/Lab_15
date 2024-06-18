using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteExplotion : MonoBehaviour
{
    private Animator _compAnimator;
    private float animationLength;
    private AudioSource _compAudioSource;
    // Start is called before the first frame update
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
        _compAudioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        _compAudioSource.Play();

        AnimationClip[] clips = _compAnimator.runtimeAnimatorController.animationClips;
        if (clips.Length > 0)
        {
            animationLength = clips[0].length;
        }
        Destroy(gameObject, animationLength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
