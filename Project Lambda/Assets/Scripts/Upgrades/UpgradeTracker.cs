using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTracker : MonoBehaviour
{
    /// <summary>
    /// UpgradeTracker tracks the points allocated to each player's upgrades as well as controls how each upgrade
    /// is enacted as well as visualized.
    /// </summary>

    /// <summary>
    /// Field that controls whether we have upgrade points or not
    /// </summary>

    public int upgradePoints;

    /// <summary>
    /// Fields that store the potency of each upgrade
    /// </summary>

    public int uBitPower;
    public int uFiringSpeed;
    public int uHealth;
    public int uArmor;
    public int uRegenSpeed;
    public int uPlayerSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        upgradePoints = 0;
        uBitPower = 0;
        uFiringSpeed = 0;
        uHealth = 0;
        uArmor = 0;
        uRegenSpeed = 0;
        uPlayerSpeed = 0;
    }

    // TODO: Check if the player can upgrade every frame (how many upgrade points).
    // If so, set keybinds to allocate upgrade points.
    // Upon upgrade, edit the necessary scripts to actualize upgrades
    // TODO LATER: Display the upgrade values on screen, hopefully using something like a bar.
    void Update()
    {
        // Press p to increase player speed.
        if (Input.GetKeyDown(KeyCode.P))
        {
            uPlayerSpeed++;
            // If uPlayerSpeed == 3, reset to 0
            if (uPlayerSpeed == 3)
            {
                uPlayerSpeed = 0;
            }
        }
        // Press f to increase firing speed
        if (Input.GetKeyDown(KeyCode.F))
        {
            uFiringSpeed++;
            // If uFiringSpeed == 3, reset to 0
            if (uFiringSpeed == 3)
            {
                uFiringSpeed = 0;
            }
        }
        // Press b to increase bit power
        if (Input.GetKeyDown(KeyCode.B))
        {
            uBitPower++;
            // If uBitPower == 3, reset to 0
            if (uBitPower == 3)
            {
                uBitPower = 0;
            }
        }
        // Press h to increase health
        if (Input.GetKeyDown(KeyCode.H))
        {
            uHealth++;
            // If uHealth == 3, reset to 0
            if (uHealth == 3)
            {
                uHealth = 0;
            }
        }
    }
}