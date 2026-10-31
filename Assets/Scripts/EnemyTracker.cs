using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class EnemyTracker : MonoBehaviour
{
    private List<string> activeEnemies = new List<string>();
    public TextMeshProUGUI inventoryText;

    void Start()
    {
        activeEnemies.Add("Goblin");
        activeEnemies.Add("Skeleton");
        activeEnemies.Add("Orc");

        UpdateUI();
    }

    public void SpawnEnemy(string enemyName)
    {
        activeEnemies.Add(enemyName);

        Debug.Log($"Spawned {enemyName}!");

        UpdateUI();
    }

    public void DefeatEnemy(string enemyName)
    {
        if (activeEnemies.Remove(enemyName))
        {
            Debug.Log($"Defeated {enemyName}!");
        }

        else
        {
            Debug.LogWarning($"Could not find {enemyName} enemy!");
        }

        UpdateUI();
    }

    public void ClearEnemies()
    {
        activeEnemies.Clear();

        Debug.Log("All enemies have been wiped out!");

        UpdateUI();
    }

    private void UpdateUI()
    {
        inventoryText.text = "Active Enemies: \n";

        for (int i = 0; i < activeEnemies.Count; i++)
        {
            inventoryText.text += $"- {activeEnemies[i]}\n";
        }
    }
}