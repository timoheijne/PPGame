using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RangeType 
{
    Melee,
    Ranged
}
[CreateAssetMenu(menuName = "EnemyDefinition/EnemyType")]
public class EnemyDefinition : ScriptableObject
{
    public string Name;
    public int Strength;
    public int Worth;
    public float Health;
    public float MoveSpeed;
    public float AttackSpeed;

    public RangeType RangeType;
}
