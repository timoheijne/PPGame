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
        DebugDefinitionStats(EnemyType);
        DebugCurrentStats();
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

    void DebugDefinitionStats(EnemyDefinition definition) 
    {
        Debug.Log("Aplying These Stats:");
        Debug.Log(definition.Name);
        Debug.Log(definition.Strength);
        Debug.Log(definition.Worth);
        Debug.Log(definition.MoveSpeed);
        Debug.Log(definition.Health);
        Debug.Log(definition.AttackSpeed);
        Debug.Log(definition.RangeType.ToString());
    }

    void DebugCurrentStats() 
    {
        Debug.Log("Current Aplied Stats:");
        Debug.Log(_enemyName);
        Debug.Log(_enemyStrength);
        Debug.Log(_enemyWorth);
        Debug.Log(_enemyMoveSpeed);
        Debug.Log(_enemyHealth);
        Debug.Log(_enemyAttackSpeed);
        Debug.Log(_enemyAttackRange);
    }
}