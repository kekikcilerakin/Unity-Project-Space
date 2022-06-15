using UnityEngine;

[CreateAssetMenu(fileName = "AKN_Laser", menuName = "AKN Infinite/Weapons/Laser", order = 0)]
public class AKN_LaserSO : ScriptableObject
{
    public new string name = "Laser";
    public GameObject prefab;
    public int defaultCount = 1;
    public float defaultCooldown = 4f;
    public float cooldown;

    private void OnEnable()
    {
        cooldown = defaultCooldown;
    }
}