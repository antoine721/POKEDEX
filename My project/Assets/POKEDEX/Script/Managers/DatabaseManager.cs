using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DatabaseManager : MonoBehaviour
{
    public PokemonDataBase database;

    public PokemonDatas GetData(int id) => database.datas[id];

    private void Start()
    {
        database.CreateData();
    }
}
