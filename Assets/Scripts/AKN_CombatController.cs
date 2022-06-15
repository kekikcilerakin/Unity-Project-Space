using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKN_CombatController : MonoBehaviour
{
    [SerializeField] private AKN_LaserSO laserSO;
    [SerializeField] private Transform[] laserPoints;

    

    private void Start()
    {
        laserSO = Instantiate(laserSO);
    }

    private void Update()
    {
        ShootLaser();
    }

    private void ShootLaser()
    {
        laserSO.cooldown -= Time.deltaTime;
        if(laserSO.cooldown < 0)
        {
            int rnd = Random.Range(0, laserPoints.Length);
            Instantiate(laserSO.prefab, laserPoints[rnd].position, laserPoints[rnd].rotation);
            laserSO.cooldown = laserSO.defaultCooldown;
        }

    }
}
