using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    
    void Awake()
    {
        BuildItemDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    void BuildItemDatabase()
    {
        items = new List<Item>()
        {
            new Item(1, "Sword", "A melee weapon. Please do not cut yourself",
            new Dictionary<string, int> {
                { "Damage", 15 },
                { "Speed", 7 }
            }),

            new Item(2, "Pistol", "A small ranged weapon or sidearm. Do NOT shoot your friends!!!",
            new Dictionary<string, int> {
                { "Damage", 50 },
                { "Speed", 15 }
            }),

            new Item(3, "Pic-N-X", "A axe and a pickaxe to cut trees and mine. Not your ex stoopid.",
            new Dictionary<string, int> {
                { "Damage", 12 },
                { "Speed", 10 },
                { "Axe power", 69 },
                { "Pickaxe power", 69}
            }),

            new Item(4, "Bow", "A bow to shoot arrows. No you are not Legolas.",
            new Dictionary<string, int> {
                { "Damage", 25 },
                { "Speed", 7 },
            }),

            new Item(5, "Wood", "to burn or craft or build.",
            new Dictionary<string, int> {
                { "Value", 25 }
            }),

            new Item(6, "Rock", "I like to hit big rock with another big rock and turn them into a smaller rocks.",
            new Dictionary<string, int> {
                { "Value", 25 }
            }),
        };
    }
}
