using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSystem : MonoBehaviour
{
    public List<PokemonDatas> allPokemon; // Liste contenant tous les Pokémon
    [SerializeField] public Dropdown dropdown1; // Menu déroulant pour choisir pokemon1
    public Dropdown dropdown2; // Menu déroulant pour choisir pokemon2
    public PokemonDatas pokemon1;
    public PokemonDatas pokemon2;

    void Start()
    {
        List<string> options = new List<string>();
        foreach (PokemonDatas pokemon in allPokemon)
        {
            options.Add(pokemon.name);
        }
        dropdown1.AddOptions(options);
        dropdown2.AddOptions(options);

        dropdown1.onValueChanged.AddListener(delegate { SetPokemon(dropdown1.value, 1); });
        dropdown2.onValueChanged.AddListener(delegate { SetPokemon(dropdown2.value, 2); });
    }

    public void SetPokemon(int index, int pokemonNumber)
    {
        PokemonDatas chosenPokemon = allPokemon[index];
        if (pokemonNumber == 1)
        {
            pokemon1 = chosenPokemon;
        }
        else if (pokemonNumber == 2)
        {
            pokemon2 = chosenPokemon;
        }
    }

    public void StartBattle()
    {
        Debug.Log("Un combat commence entre " + pokemon1.name + " et " + pokemon2.name + " !");
        while (pokemon1.stats.hp > 0 && pokemon2.stats.hp > 0)
        {
            Attack(pokemon1, pokemon2);
            if (pokemon2.stats.hp > 0)
            {
                Attack(pokemon2, pokemon1);
            }
        }

        if (pokemon1.stats.hp <= 0)
        {
            Debug.Log(pokemon2.name + " a gagné contre " + pokemon1.name + " ! Il lui restait " + pokemon2.stats.hp + " HP.");
        }
        else
        {
            Debug.Log(pokemon1.name + " a gagné contre " + pokemon2.name + " ! Il lui restait " + pokemon1.stats.hp + " HP.");
        }
    }

    public void Attack(PokemonDatas attacker, PokemonDatas defender)
    {
        int damage = attacker.stats.attack - defender.stats.defense;
        if (damage < 0) damage = 0;
        defender.stats.hp -= damage;
        Debug.Log(attacker.name + " attaque " + defender.name + " et lui inflige " + damage + " points de dégâts !");
    }
}
