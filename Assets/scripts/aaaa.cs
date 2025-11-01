using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldAnimationStarter : MonoBehaviour
{

    public Animator animationComponent;

    // Start is called before the first frame update
    void Start()
    {
        animationComponent = GetComponent<Animator>();
    }

    public void Playfait()
    {
        animationComponent.SetBool("fait", true);
    }
    public void PlayRun()
    {
        animationComponent.SetBool("run", true);
    }
}
