using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Animation animationToPlay;

    public void playAnimation()
    {
        animationToPlay.Play();
    }
}
