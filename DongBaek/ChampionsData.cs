using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ChampionsData : MonoBehaviour
{
    public GameObject 아리;
    public GameObject 아트록스;
    public GameObject 아칼리;
    public GameObject 갈리오;
    // public Dictionary<GameObject,string> data = new Dictionary<GameObject,string>();
    // public void GetData(){
    //     data.Add(아리, "아리");
    //     data.Add(아트록스, "아트록스");
    //     data.Add(아칼리, "아칼리");
    //     data.Add(갈리오, "갈리오");
    // }


    public List<GameObject> data = new List<GameObject>();
    public List<GameObject> data2 = new List<GameObject>();
    void Data(){
        data.AddRange(new List<GameObject>{아리, 아트록스, 아칼리, 갈리오}) ;
    }

//String형태로 변수를 재정의? (오버로딩)
    public string GetDatatoRandom(){
        int random = Random.Range(0, data.Count);
        data[random];
    }
}