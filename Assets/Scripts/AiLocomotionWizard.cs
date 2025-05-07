using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiLocomotionWizard : MonoBehaviour
{
    public Transform playerTransform;
    public Transform agentTransform;
    NavMeshAgent agent;
    Animator animator;
    int health=0; 

    // Start is called before the first frame update
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        animator=GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = playerTransform.position;
        animator.SetFloat("Speed",agent.velocity.magnitude);
        float distance = Vector3.Distance(agentTransform.position, playerTransform.position);
        animator.SetFloat("Destination",(distance));
        
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Walk")){
            agent.speed=2;
        }
        else if(this.animator.GetCurrentAnimatorStateInfo(0).IsName("Attack")){
            agent.speed=0.2f;
        }
        else {
            agent.speed=0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Melee"){
            health++;
        }
        if (health==2){
            animator.SetTrigger("Die");
            GetComponent<EnemyAI>().enabled = false;


        }
    }
}
