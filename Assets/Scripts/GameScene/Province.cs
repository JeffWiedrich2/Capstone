using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ProvinceType
{
    industrial, residential, commercial, devastated, police
}

public class Province : MonoBehaviour
{
    public Transform mainCamera;
    public GameObject gameScreen;
    public GameObject provinceScreen;
    public GameObject[] provinces;
    public UnityEngine.UI.Slider provinceDefenseSlider;

    [Header("Province Information")]
    public ProvinceType provinceType;
    public int provinceIncome;
    public int provinceResources;
    public CheckStatistics provinceController;
    public bool containsFort;
    public float opinion;
    public float provinceDefense;
    public ArmyGroup[] armies;

    [Header("Set Dynamically")]
    public Leader leader;
    public Unit unit;
    public bool isLeader;
    

    // Start is called before the first frame update
    void Start()
    {
        switch (provinceType)
        {
            case ProvinceType.industrial:
                provinceIncome = 4;
                provinceResources = 5;
                containsFort = false;
                opinion = 1;
                provinceDefense = 0;
                break;
            case ProvinceType.residential:
                provinceIncome = 3;
                provinceResources = 3;
                containsFort = false;
                opinion = 1.5f;
                provinceDefense = 0;
                break;
            case ProvinceType.commercial:
                provinceIncome = 5;
                provinceResources = 4;
                containsFort = false;
                opinion = 1.5f;
                provinceDefense = 0;
                break;
            case ProvinceType.devastated:
                provinceIncome = 1;
                provinceResources = 2;
                containsFort = false;
                opinion = 3;
                provinceDefense = 0;
                break;
            case ProvinceType.police:
                provinceIncome = 2;
                provinceResources = 1;
                containsFort = false;
                opinion = 0;
                provinceDefense = 0;
                break;
            default:
                break;
        }
        provinceDefenseSlider.value = 0;
        armies = new ArmyGroup[0];
    }

    void Update()
    {
        if (gameScreen.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if (hit.collider != null)
                {
                    mainCamera.position = new Vector3(mousePos2D.x, mousePos2D.y, -3f);
                    gameScreen.SetActive(false);
                    provinceScreen.SetActive(true);
                }
            }
        }
    }

    public void RecruitUnit()
    {
        foreach (GameObject province in provinces)
        {
            if (province.transform.position.x == mainCamera.position.x && province.transform.position.y == mainCamera.position.y)
            {
                Province selectedProvince = province.GetComponent<Province>();
                if (isLeader)
                {
                    ArmyGroup[] temp = new ArmyGroup[armies.Length + 1];
                    armies.CopyTo(temp, 0);
                    temp[armies.Length].leader = leader;
                    armies = temp;

                    provinceController.money -= leader.costMoney;
                    provinceResources -= leader.costResources;
                }
                else
                {
                    Unit[] units = armies[armies.Length - 1].units;
                    Unit[] temp = new Unit[units.Length + 1];
                    units.CopyTo(temp, 0);
                    temp[units.Length] = unit;
                    armies[armies.Length - 1].units = temp;

                    provinceController.money -= unit.costMoney;
                    provinceResources -= unit.costResources;
                }
            }
        }
    }

    public void SetProvinceDefense()
    {
        foreach (GameObject province in provinces)
        {
            if (province.transform.position.x == mainCamera.position.x && province.transform.position.y == mainCamera.position.y)
            {
                Province selectedProvince = province.GetComponent<Province>();
                provinceDefenseSlider.minValue = 0;
                provinceDefenseSlider.maxValue = provinceController.money;

                selectedProvince.provinceDefense = provinceDefenseSlider.value;
                provinceController.money -= (int)provinceDefenseSlider.value;
            }
        }
    }

    public void BuildFort()
    {
        foreach (GameObject province in provinces)
        {
            if (province.transform.position.x == mainCamera.position.x && province.transform.position.y == mainCamera.position.y)
            {
                Province selectedProvince = province.GetComponent<Province>();
                selectedProvince.containsFort = true;
                provinceController.money -= 50;
            }
        }
    }
}
