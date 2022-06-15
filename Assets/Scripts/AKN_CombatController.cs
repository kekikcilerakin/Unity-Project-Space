using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKN_CombatController : MonoBehaviour
{
    [SerializeField] private List<AKN_WeaponSO> weapons;
    public Transform[] laserPoints;
    public Transform[] missilePoints;

    public string selectedShip;
    public AKN_WeaponDB weaponDB;
    

    private void Start()
    {
        if (selectedShip == "1")
        {
            weapons.Add(Instantiate(weaponDB.weapons[0]));
        }
        else if (selectedShip == "2")
        {
            weapons.Add(Instantiate(weaponDB.weapons[1]));
        }
    }

    private void Update()
    {
        foreach (AKN_WeaponSO weapon in weapons)
        {
            weapon.Shoot();
        }
    }
}
