using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
//내비매쉬에이전트  컴퍼넌트가 없으면 경고나 오류를 발생시킨다.

public class Moveghost : MonoBehaviour
{
    public List<Transform> wayPoints;
    public int nextIdx;
    [SerializeField]
    NavMeshAgent agent;
    private readonly float patrolSpeed = 0.8f;
    private readonly float traceSpeed = 3f;
  

    private bool _patrolling;
    public bool patrolling
    {
        get { return _patrolling; }
        set
        {
            _patrolling = value;
            if(_patrolling)
            {
                agent.speed = patrolSpeed;
             
                MoveWayPoint();

            }

        }
    }
    private Vector3 _tracetarget;
    public Vector3 tracetarget
    {
        get { return _tracetarget; }
        set
        {
            _tracetarget = value;
            agent.speed = traceSpeed;
           
            TraceTarget(_tracetarget);
            
        }

    }
    public void Stop()
    {
        agent.isStopped = true;
        agent.velocity = Vector3.zero;
        _patrolling = false;
    }

    void TraceTarget(Vector3 pos)
    {
        if (agent.isPathStale) return;

        agent.destination = pos;
        agent.isStopped = false;
    }
    public float speed  // 프로퍼티
    {

        get { return agent.velocity.magnitude; }
            //내비메시 에이전트의 속도를 반환
    }


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        
        var group = GameObject.Find("Patrolpoints");
        if(group !=null)
        {
            group.GetComponentsInChildren<Transform>(wayPoints);
            wayPoints.RemoveAt(0);
        }
        MoveWayPoint();

    }
    void MoveWayPoint()
    {
        if (agent.isPathStale) return;
        //최단 경로가 검색되지 않으면 빠져나간다.
        agent.destination = wayPoints[nextIdx].position;
        agent.isStopped = false;

    }
  
    void Update()
    {
    

        if (!_patrolling) return;

        if(agent.remainingDistance <=0.5f && agent.velocity.sqrMagnitude >=0.2f *0.2f)
        {
            nextIdx = ++nextIdx % wayPoints.Count;
            MoveWayPoint();
        }
    }
}
