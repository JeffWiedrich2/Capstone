using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Unit
{
    public GameObject unitPrefab;
    public int health;
    public float attackValue;
    public float defenseValue;
    public float speed;
    public float morale;
    public int costMoney;
    public int costResources;
}

public class Leader
{
    public GameObject leaderPrefab;
    public int health;
    public float attackValue;
    public float defenseValue;
    public float speed;
    public float morale;
    public int costMoney;
    public int costResources;
    public int leadership;
}


public class ArmyGroup : MonoBehaviour
{
    public Leader leader;
    public Unit[] units;
}
