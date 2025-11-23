using UnityEngine;
using UnityEngine.AI;

public class run : MonoBehaviour
{
    Animator animationComponent;
    public Transform player; 
    private NavMeshAgent agent;
    float speedAgentX;
    float speedAgentZ;
    public float attackRange = 2f; 
    public float followDistance = 25f; 
    public float stopDistance = 18f; 
    public float idleDistance = 25f; 
    public float timeBetweenAttacks = 1f; 
    private float nextAttackTime = 0f;
    bool isIdle = false;

    void Start()
    {
        animationComponent = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        Run();
        Attack();
        Idel();
    }

    private void Run()
    {
        speedAgentX = agent.velocity.x;
        speedAgentZ = agent.velocity.z;

        
        if (player != null && agent != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position); 

            if (distanceToPlayer <= followDistance) 
            {
                agent.SetDestination(player.position); 

                if (speedAgentX > 1 || speedAgentZ > 1) 
                {
                    animationComponent.SetBool("run", true); 
                }
                else if (!agent.pathPending && agent.remainingDistance > 0.5f)
                {
                    animationComponent.SetBool("run", true); 
                }
                else
                {
                    animationComponent.SetBool("run", false); 
                }
            }
            else if (distanceToPlayer > stopDistance) 
            {
                agent.ResetPath(); 
                animationComponent.SetBool("run", false); 
            }
        }
    }

    private void Attack()
    {
        if (player != null && Time.time >= nextAttackTime)
        {
            float distanceToTarget = Vector3.Distance(transform.position, player.position);

            if (distanceToTarget <= attackRange)
            {
                animationComponent.SetTrigger("attack"); 
                nextAttackTime = Time.time + timeBetweenAttacks;
            }
            else
            {
                animationComponent.SetBool("attack", false);
            }
        }
        
    }

    private void Idel()
    {
        if (player != null)
        {
            if (player != null)
            {
                float distanceToPlayer = Vector3.Distance(transform.position, player.position);

                if (distanceToPlayer > idleDistance && !isIdle) 
                {
                    isIdle = true;
                    agent.isStopped = true; 
                    animationComponent.SetBool("run", false); 
                    animationComponent.SetBool("idle", true);
                }
                else if (distanceToPlayer <= followDistance && isIdle) 
                {
                    isIdle = false; 
                    agent.isStopped = false;
                    animationComponent.SetBool("idle", false); 
                }
            }
        }
    }
     private void Walk()
    {
        
    }
}   