using System;
using System.Collections.Generic;
using UnityEngine;

public class GachaManager : MonoBehaviour
{
    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    // Define a GachaLetter class to hold letter data and rarity
    [System.Serializable]
    public class GachaLetter
    {
        public string Letter;  // The letter itself
        public Rarity rarity;  // The rarity of the letter
    }

    // List of possible Gacha letters, each with its rarity
    public List<GachaLetter> gachaLetters;

    // Dictionary to hold rarity weights (probability of getting each rarity)
    private Dictionary<Rarity, float> rarityWeights = new Dictionary<Rarity, float>
    {
        { Rarity.Common, 50f },    // 50% chance for common letters
        { Rarity.Uncommon, 30f },  // 30% chance for uncommon letters
        { Rarity.Rare, 15f },      // 15% chance for rare letters
        { Rarity.Epic, 4f },       // 4% chance for epic letters
        { Rarity.Legendary, 1f }   // 1% chance for legendary letters
    };

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the Gacha letters (for example purposes)
        InitializeGachaLetters();
        
        // Example: Pull a letter when the game starts
        GachaLetter pulledLetter = GetRandomGachaLetter();
        Debug.Log("You pulled: " + pulledLetter.Letter + " with rarity " + pulledLetter.rarity);
    }

    // Initialize the Gacha letters (you can add more letters or change this logic)
    private void InitializeGachaLetters()
    {
        gachaLetters = new List<GachaLetter>
        {
            new GachaLetter { Letter = "A", rarity = Rarity.Legendary },
            new GachaLetter { Letter = "B", rarity = Rarity.Common },
            new GachaLetter { Letter = "C", rarity = Rarity.Uncommon },
            new GachaLetter { Letter = "D", rarity = Rarity.Rare },
            new GachaLetter { Letter = "E", rarity = Rarity.Epic },
            // Add more letters as needed
        };
    }

    // Get a random Gacha letter based on the rarity weights
    private GachaLetter GetRandomGachaLetter()
    {
        // Get a random rarity based on the weights
        Rarity randomRarity = GetRandomRarity();
        
        // Get all letters of the selected rarity
        List<GachaLetter> availableLetters = gachaLetters.FindAll(letter => letter.rarity == randomRarity);

        // Randomly choose a letter from the available letters of the selected rarity
        int randomIndex = UnityEngine.Random.Range(0, availableLetters.Count);
        return availableLetters[randomIndex];
    }

    // Get a random rarity based on the defined rarity weights
    private Rarity GetRandomRarity()
    {
        float totalWeight = 0f;
        foreach (float weight in rarityWeights.Values)
        {
            totalWeight += weight;
        }

        float randomValue = UnityEngine.Random.Range(0f, totalWeight);
        float cumulativeWeight = 0f;

        foreach (KeyValuePair<Rarity, float> rarityWeight in rarityWeights)
        {
            cumulativeWeight += rarityWeight.Value;
            if (randomValue < cumulativeWeight)
            {
                return rarityWeight.Key;
            }
        }

        return Rarity.Common;
    }
}