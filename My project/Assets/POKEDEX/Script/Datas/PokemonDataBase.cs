using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Pokemon", menuName = "Database/Pokemon", order=0)]
public class PokemonDataBase : ScriptableObject
{
    public List<PokemonDatas> datas = new();

    public void CreateData()
    {
        datas.Clear(); // Supprime tous les Pokémon existants

        // Ajoutez chaque Pokémon à la base de données
        PokemonStat bulbasaurStats = new PokemonStat(6, 6, 45);
        datas.Add(new PokemonDatas(1, "Bulbizarre", "Plante", 0.7f, 6.9f, 5, "Il naît avec une graine sur le dos. Elle grandit lentement.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/001.png"), 1, bulbasaurStats));

        PokemonStat ivysaurStats = new PokemonStat(8, 8, 60);
        datas.Add(new PokemonDatas(2, "Herbizarre", "Plante", 1.0f, 13.0f, 16, "Lorsqu'il dort à l'ombre d'un grand arbre, il peut absorber suffisamment de lumière pour faire pousser son bulbe.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/002.png"), 2, ivysaurStats));

        PokemonStat venusaurStats = new PokemonStat(12, 12, 80);
        datas.Add(new PokemonDatas(3, "Florizarre", "Plante", 2.0f, 100.0f, 32, "Il répand un parfum délicieux de fleurs pour endormir sa proie. Ensuite, il l'attrape et la dévore.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/003.png"), -1, venusaurStats));

        PokemonStat charmanderStats = new PokemonStat(6, 4, 39);
        datas.Add(new PokemonDatas(4, "Salamèche", "Feu", 0.6f, 8.5f, 5, "On raconte que la flamme sur sa queue indique l'humeur de ce Pokémon.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/004.png"), 1, charmanderStats));

        PokemonStat charmeleonStats = new PokemonStat(8, 6, 58);
        datas.Add(new PokemonDatas(5, "Reptincel", "Feu", 1.1f, 19.0f, 16, "Sa flamme brûle plus fortement quand il est en colère. Il crache des flammes capables de faire fondre n'importe quoi.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/005.png"), 2, charmeleonStats));

        PokemonStat charizardStats = new PokemonStat(12, 8, 78);
        datas.Add(new PokemonDatas(6, "Dracaufeu", "Feu / Vol", 1.7f, 90.5f, 36, "On raconte qu'il est capable de carboniser tout ce qui l'entoure. On le voit rarement dans la nature.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/006.png"), -1, charizardStats));

        PokemonStat squirtleStats = new PokemonStat(5, 7, 44);
        datas.Add(new PokemonDatas(7, "Carapuce", "Eau", 0.5f, 9.0f, 5, "Il cache sa tête dans sa carapace. Il lance des attaques avec ses bras.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/007.png"), 1, squirtleStats));

        PokemonStat wartortleStats = new PokemonStat(7, 9, 59);
        datas.Add(new PokemonDatas(8, "Carabaffe", "Eau", 1.0f, 22.5f, 16, "Il bombarde l'ennemi de jets d'eau d'une puissance surprenante. C'est un excellent nageur.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/008.png"), 2, wartortleStats));

        PokemonStat blastoiseStats = new PokemonStat(9, 12, 79);
        datas.Add(new PokemonDatas(9, "Tortank", "Eau", 1.6f, 85.5f, 36, "Quand il contracte ses pattes et sa tête dans sa carapace, il devient presque invincible.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/009.png"), -1, blastoiseStats));

        PokemonStat pikachuStats = new PokemonStat(6, 5, 35);
        datas.Add(new PokemonDatas(10, "Pikachu", "Électrik", 0.4f, 6.0f, 5, "Chaque fois qu'il rencontre quelque chose de nouveau, il envoie un choc électrique.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/025.png"), -1, pikachuStats));

        PokemonStat rondoudouStats = new PokemonStat(6, 5, 115);
        datas.Add(new PokemonDatas(11, "Rondoudou", "Normal", 0.5f, 5.5f, 5, "Sa chanson triste peut rendre quiconque l'entend heureux ou triste.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/039.png"), -1, rondoudouStats));

        PokemonStat machocStats = new PokemonStat(10, 7, 70);
        datas.Add(new PokemonDatas(13, "Machoc", "Combat", 0.8f, 19.5f, 5, "Il donne des coups de poing avec ses bras pour s'échauffer. Ses poings ont durci.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/066.png"), -1, machocStats));

        PokemonStat psykokwakStats = new PokemonStat(6, 6, 50);
        datas.Add(new PokemonDatas(16, "Psykokwak", "Eau", 0.8f, 19.6f, 5, "Ses pattes palmées lui permettent de nager vigoureusement et de courir à grande vitesse.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/054.png"), -1, psykokwakStats));

        PokemonStat miaoussStats = new PokemonStat(8, 6, 40);
        datas.Add(new PokemonDatas(18, "Miaouss", "Normal", 0.4f, 4.2f, 5, "Il aime les pièces brillantes. Il se cache dans des endroits sombres.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/052.png"), -1, miaoussStats));

        PokemonStat chenipanStats = new PokemonStat(5, 5, 45);
        datas.Add(new PokemonDatas(20, "Chenipan", "Insecte", 0.3f, 2.9f, 5, "Son corps souple lui permet de passer dans des fissures étroites et d'éviter les prédateurs.", AssetDatabase.LoadAssetAtPath<Sprite>("Assets/POKEDEX/photo/010.png"), -1, chenipanStats));

    }

}

