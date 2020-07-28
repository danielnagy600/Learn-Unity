using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MuccerMovement : MonoBehaviour
{
    public NavMeshAgent _navMeshAgent;
    private Animator _animator;
    private Transform _PlayerDestinationPosition;


    private int _runHash;
    private int _fightHahs;
    private bool isFight;

    public void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
        _runHash = Animator.StringToHash("isRun");
        _fightHahs = Animator.StringToHash("isFight");
        isFight = false;
    }

    private void OnTriggerEnter(Collider someone)
    {
        if (someone.tag == "Player")
        {
          
            _PlayerDestinationPosition = GameObject.FindGameObjectWithTag("Player").transform;
            _animator.SetBool(_runHash, true);
            _navMeshAgent.SetDestination(_PlayerDestinationPosition.position);
        }
    }

    public void Update()
    {      
            if (_PlayerDestinationPosition != null && Vector3.Distance(_PlayerDestinationPosition.position, this.transform.position) < 10)
            {
                Vector3 directon = _PlayerDestinationPosition.position - this.transform.position;
                directon.y = 0;
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(directon), 0.1f);
              
                if (isFight==false && Vector3.Distance(_PlayerDestinationPosition.position, this.transform.position) < 4.5)
                {
                    _animator.SetBool(_fightHahs, true);
                    isFight = true;
                }
                else
                {
                    _animator.SetBool(_fightHahs, false);
                    _animator.SetBool(_runHash, false);
                    isFight = false;
            }
            _navMeshAgent.SetDestination(_PlayerDestinationPosition.position);
            }
    }
}
