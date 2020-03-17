using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour 
{
    public EnemyDefinition EnemyType;

    private string _enemyName;
    private int _enemyStrength;
    private int _enemyWorth;
    private float _enemyMoveSpeed;
    private float _enemyHealth;
    private float _enemyAttackSpeed;
    private float _enemyAttackRange;

    private void Start() 
    {
        SetEnemy(EnemyType);
    }

    public void SetEnemy(EnemyDefinition definition) 
    {
        _enemyName = definition.Name;
        _enemyStrength = definition.Strength;
        _enemyWorth = definition.Worth;
        _enemyMoveSpeed = definition.MoveSpeed;
        _enemyHealth = definition.Health;
        _enemyAttackSpeed = definition.AttackSpeed;

        if (definition.RangeType == RangeType.Ranged) {
            _enemyAttackRange = 5;
        } 
        else 
        {
            _enemyAttackRange = 2;
        }
    }
}