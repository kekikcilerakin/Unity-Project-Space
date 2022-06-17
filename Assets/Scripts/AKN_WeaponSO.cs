using UnityEngine;

[CreateAssetMenu(fileName = "AKN_Weapon", menuName = "AKN Infinite/Weapons/AKN_Weapon", order = 0)]
public class AKN_WeaponSO : ScriptableObject
{
    public new string name = "default";
    public GameObject prefab;

    public float defaultProjectileSpeed = 5.5f;
    public float currentProjectileSpeed;

    public int level = 0;
    public int currentProjectileCount = 0;
    public int maxProjectileCount = 5;

    public float defaultCooldown = 4f;
    public float currentCooldown;

    private AKN_CombatController combatController;

    private void OnEnable()
    {
        currentProjectileSpeed = defaultProjectileSpeed;
        currentCooldown = defaultCooldown;

        combatController = GameObject.Find("Player").GetComponent<AKN_CombatController>();
    }


    public void LevelUp()
    {
        if (level < 5)
        {
            level++;
        }

    }

    public void AddProjectile()
    {
        if (currentProjectileCount < maxProjectileCount)
        {
            currentProjectileCount++;
        }
    }

    public void Shoot()
    {
        
        currentCooldown -= Time.deltaTime;
        if(currentCooldown < 0)
        {
            for (int i = 0; i < currentProjectileCount; i++)
            {
                if (name == "Laser")
                    Instantiate(prefab, combatController.laserPoints[i].position, combatController.laserPoints[i].rotation);
                else if (name == "Missile")
                    Instantiate(prefab, combatController.missilePoints[i].position, combatController.missilePoints[i].rotation);
                
                currentCooldown = defaultCooldown;
                
            }
            AddProjectile(); //delete later
        }
    }
}