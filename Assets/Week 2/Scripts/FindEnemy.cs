using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    private List<EnemyAbstract> _enemyList = new List<EnemyAbstract>();
    private EnemyAbstract _lowestHealthEnemy;
    private EnemyAbstract _highestHealthEnemy;

    private void Start()
    {
        LoadEnemy();
        ShowEnemy();
        Debug.Log($" Enemy co mau thap nhat {FindEnemyWithSmallestHealth(_enemyList)}", FindEnemyWithSmallestHealth(_enemyList).gameObject);
        Debug.Log($" Enemy co mau cao nhat {FindEnemyWithLargestHealth(_enemyList)}", FindEnemyWithLargestHealth(_enemyList).gameObject);
    }

    private void LoadEnemy()
    {
        foreach (Transform child in transform)
        {
            EnemyAbstract enemy = child.GetComponent<EnemyAbstract>();
            _enemyList.Add(enemy);
        }
    }

    private void ShowEnemy()
    {
        foreach (EnemyAbstract enemy in _enemyList)
        {
            Debug.Log($"{enemy.name} co luong mau la :{enemy.getHeath()}");
        }
    }

    //----------------------Edit below here --------------------
    public EnemyAbstract FindEnemyWithSmallestHealth(List<EnemyAbstract> enemyList)
    {
        if (enemyList == null ||  enemyList.Count == 0)
            return null;
        
        _lowestHealthEnemy = enemyList[0];

        foreach (EnemyAbstract enemy in enemyList)
        {
            if (_lowestHealthEnemy.getHeath() > enemy.getHeath())
                _lowestHealthEnemy = enemy;
        }

        return _lowestHealthEnemy;
    }

    public EnemyAbstract FindEnemyWithLargestHealth(List<EnemyAbstract> enemyList)
    {
        if (enemyList == null || enemyList.Count == 0)
            return null;

        _highestHealthEnemy = enemyList[0];

        foreach (EnemyAbstract enemy in enemyList)
        {
            if (_highestHealthEnemy.getHeath() < enemy.getHeath())
                _highestHealthEnemy = enemy;
        }

        return _highestHealthEnemy;
    }
}

