using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class PokemonDatas
{
    public int pokedexNumber;
    public string name;
    public string type;
    public float size;
    public float weight;
    public int level;
    public string caption;
    public Sprite icon;
    public int evolvesTo;
    public PokemonStat stats;


    public PokemonDatas(int pokedexNumber, string name, string type, float size, float weight, int level, string caption, Sprite icon, int evolvesTo, PokemonStat stats)

    {
        this.pokedexNumber = pokedexNumber;
        this.name = name;
        this.type = type;
        this.size = size;
        this.weight = weight;
        this.level = level;
        this.caption = caption;
        this.icon = icon;
        this.evolvesTo = evolvesTo;
        this.stats = stats;
    }
}

