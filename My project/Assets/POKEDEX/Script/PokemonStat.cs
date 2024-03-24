using System;
using System.Collections;
using System;
using UnityEngine;

[Serializable]
public class PokemonStat
{
    public int hp;
    public int attack;
    public int defense;


    public PokemonStat(int hp, int attack, int defense)
    {
        this.attack = attack;
        this.defense = defense;
        this.hp = hp;
    }
}

