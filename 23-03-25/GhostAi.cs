using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.FirstPerson;

public class GhostAi : MonoBehaviour
{
    public enum State { PATROL, TRACE,ATTACK,DIE }
    public State state = State.PATROL;
    [SerializeField] private Transform playerTr;
    [SerializeField] private Transform tr;
    [SerializeField] private Animator animator;
   


    public float traceDist = 10f;
    public float attackDist = 0.5f;
    public bool isDIe = false;

    new WaitForSeconds ws;
    Moveghost moveghost;
    private FirstPersonController fpsController;

    private readonly int hasMove = Animator.StringToHash("Iswalk");
    private readonly int hasSpeed = Animator.StringToHash("Fowardspeed");
    void Awake()
    {
       
        playerTr = GameObject.FindGameObjectWithTag("Player").transform;
        tr = this.transform;
        ws = new WaitForSeconds(0.25f);
        moveghost = GetComponent<Moveghost>();
        fpsController = GameObject.Find("FPSController").GetComponent<FirstPersonController>();
        animator = GetComponent<Animator>();
        if (fpsController == null)
        {
            Debug.LogError("fpsController is null");
        }

    }
    private void OnEnable()
    {
        StartCoroutine(CheckState());
        StartCoroutine(EnemyAction());
    }
    IEnumerator CheckState()
    {
        while (!isDIe)
        {
            float dist = Vector3.Distance(tr.position, playerTr.position);

            if (fpsController.FLight_onoff == false && fpsController.m_isDown)
            {
                if (dist <= attackDist) // m_isdown이 true이면 attackDist를 절반으로 설정
                {
                    state = State.ATTACK;
                }
                else if (dist <= traceDist - 3.5f) // m_isdown이 true이면 traceDistDist를 절반으로 설정
                {
                    state = State.TRACE;
                }
                else
                {
                    state = State.PATROL;
                }
            }
            else if (fpsController.FLight_onoff == true)
            {
                if (dist <= attackDist)
                {
                    state = State.ATTACK;
                }
                else if (dist <= traceDist * 2f)
                {
                    state = State.TRACE;
                }
                else
                {
                    state = State.PATROL;
                }
            }
            else
            {
                if (dist <= attackDist)
                {
                    state = State.ATTACK;
                }
                else if (dist <= traceDist)
                {
                    state = State.TRACE;
                }
                else
                {
                    state = State.PATROL;
                }
            }
             
            yield return ws;
        }
    }
   IEnumerator EnemyAction()
    {
        while(!isDIe)
        {
            yield return ws;
            switch (state)
            {
                case State.PATROL:
                    moveghost.patrolling = true;
                    animator.SetBool(hasMove, true);
                    break;
                case State.TRACE:
                    moveghost.tracetarget = playerTr.position;
                    animator.SetBool(hasMove, true);
                    break;
                case State.ATTACK:
                    moveghost.Stop();
                    animator.SetBool(hasMove, false);
                    break;

                case State.DIE:

                    break;
            }

        }

    }
    private void Update()
    {
        animator.SetFloat(hasSpeed, moveghost.speed);
    }


}
