using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbstract : MonoBehaviour
{
    private string _enemyName;
    private int _enemyHeathCurrent;
    //private int enemyHeathStart;
    private bool _isDead;
    private int _minHp = 1;
    private int _maxHp = 10;

    private void Awake()
    {
        setHeath();
    }
    public int setHeath()
    {
        _enemyHeathCurrent  = Random.Range(_minHp, _maxHp);
        return _enemyHeathCurrent;
    }

    public int getHeath()
    {
        return _enemyHeathCurrent;
    }
}
