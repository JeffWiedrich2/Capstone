using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitUnit : MonoBehaviour
{
    public GameObject prefab; 
    public int health;
    public float attackValue;
    public float defenseValue;
    public float speed;
    public float morale;
    public int costMoney;
    public int costResources;
    public int leadership;
    public bool leader;

    [Header("Technical Info")]
    public GameObject recruitButton;
    public Province selectedProvince;
    public Transform mainCamera;
    public Province exampleProvince;

    [Header("Set Dynamically")]
    public Leader leaderRecruit;
    public Unit unitRecruit;
    public GameObject[] provinces;

    private void Start()
    {
        provinces = exampleProvince.provinces;
    }

    public void SelectForRecruitment()
    {
        recruitButton.SetActive(true);

        foreach (GameObject province in provinces)
        {
            if (province.transform.position.x == mainCamera.position.x && province.transform.position.y == mainCamera.position.y)
            {
                selectedProvince = province.GetComponent<Province>();
                if (leader)
                {
                    leaderRecruit.leaderPrefab = prefab;
                    leaderRecruit.health = health;
                    leaderRecruit.attackValue = attackValue;
                    leaderRecruit.defenseValue = defenseValue;
                    leaderRecruit.speed = speed;
                    leaderRecruit.morale = morale;
                    leaderRecruit.costMoney = costMoney;
                    leaderRecruit.costResources = costResources;
                    leaderRecruit.leadership = leadership;

                    selectedProvince.leader = leaderRecruit;
                }
                else
                {
                    unitRecruit.unitPrefab = prefab;
                    unitRecruit.health = health;
                    unitRecruit.attackValue = attackValue;
                    unitRecruit.defenseValue = defenseValue;
                    unitRecruit.speed = speed;
                    unitRecruit.morale = morale;
                    unitRecruit.costMoney = costMoney;
                    unitRecruit.costResources = costResources;
                    
                    selectedProvince.unit = unitRecruit;
                }
            }
        }
    }
}
