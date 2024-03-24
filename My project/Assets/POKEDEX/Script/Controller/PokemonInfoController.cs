using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

    
public class PokemonInfoController : MonoBehaviour
{
    [SerializeField] private Image _imgIcon;
    [SerializeField] private TMP_Text _txtPokedexNumber; // Ajout de la variable pour le numéro du Pokédex
    [SerializeField] private TMP_Text _txtName;
    [SerializeField] private TMP_Text _txtType;
    [SerializeField] private TMP_Text _txtLevel;
    [SerializeField] private TMP_Text _txtSize;
    [SerializeField] private TMP_Text _txtWeight;
    [SerializeField] private TMP_Text _txtCaption;

    private DatabaseManager _databaseMgr;

    private int x = 0;

    private void Awake()
    {
        _databaseMgr = FindObjectOfType<DatabaseManager>();
    }

    void Start()
    {
        PokemonDatas data = _databaseMgr.GetData(x);

        _imgIcon.sprite = data.icon;
         // Assignation du numéro du Pokédex
        if (data.pokedexNumber <=9 )
        {
            _txtPokedexNumber.text = "00" + data.pokedexNumber.ToString();
        } else
        {
            _txtPokedexNumber.text = "0" + data.pokedexNumber.ToString();
        }
        _txtName.text = data.name;
        _txtType.text = data.type;
        _txtLevel.text = "N° " + data.level.ToString();
        _txtSize.text = data.size.ToString();
        _txtWeight.text = data.weight.ToString();
        _txtCaption.text = data.caption;
    }


    public void PrevButton()
    {

        if (x == 0) {
            x = 14;
            ChangePokemon(x);
        }
        else
        {
            x--;
            ChangePokemon(x);
        }       
    }

    public void NextButton()
    {
        if (x == 14)
        {
            x = 0;
            ChangePokemon(x);
        }
        else
        {
            x++;
            ChangePokemon(x);
        }
    }

    public void ChangePokemon(int id)
    {
        PokemonDatas data = _databaseMgr.GetData(id);

        _imgIcon.sprite = data.icon;
        // Assignation du numéro du Pokédex
        if (data.pokedexNumber <= 9)
        {
            _txtPokedexNumber.text = "00" + data.pokedexNumber.ToString();
        }
        else
        {
            _txtPokedexNumber.text = "0" + data.pokedexNumber.ToString();
        }
        _txtName.text = data.name;
        _txtType.text = data.type;
        _txtLevel.text = "N° " + data.level.ToString();
        _txtSize.text = data.size.ToString();
        _txtWeight.text = data.weight.ToString();
        _txtCaption.text = data.caption;
    }

    public void Evolve()
    {
        PokemonDatas currentPokemon = _databaseMgr.GetData(x);
        if (currentPokemon.evolvesTo != -1)
        {
            x = currentPokemon.evolvesTo;
            ChangePokemon(x);
        }
    }

    private void Update()
    {
        // Peut être utilisé pour des mises à jour en temps réel si nécessaire
    }
}
