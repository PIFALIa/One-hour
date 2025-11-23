using UnityEngine;

public class OldAnimationStarter : MonoBehaviour
{
    public Animator animationComponent;

    void Start()
    {
        animationComponent = GetComponent<Animator>();
    }

    public void PlayAttack()
    {
        animationComponent.SetBool("attack", true);
    }
    public void PlayIdle()
    {
        animationComponent.SetBool("idle", true);
    }
    public void PlayJupm()
    {
        animationComponent.SetBool("jump", true);
    }
    public void PlayWalk()
    {
        animationComponent.SetBool("walk", true);
    }
    public void PlayRage()
    {
        animationComponent.SetBool("rage", true);
    }
    public void PlayAttack3()
    {
        animationComponent.SetBool("attack3", true);
    }
    public void PlayWalkback()
    {
        animationComponent.SetBool("walkback", true);
    }
    public void PlayAttack2()
    {
        animationComponent.SetBool("attack2", true);
    }
    public void run1()
    {
        animationComponent.SetBool("run", true);
    }
}