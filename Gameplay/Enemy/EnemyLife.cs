using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public void Start()
    {
        _life = 10;
    }



    private int _life;

    public int Life
    {
        set
        {
            _life -= value;
            if (_life == 0) Die();
        }

    }

    public void Die()
    {
        GetComponent<Animator>().SetBool("isDying", true);
        GetComponent<MuccerMovement>()._navMeshAgent.isStopped = true;

    }
}
