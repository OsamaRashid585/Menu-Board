using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridManager : MonoBehaviour
{
    public List<GameObject> Item = new List<GameObject>();
    public List<string> BirdsName = new List<string>();
    private GameObject _slot;
    private void Start()
    {
        AssignSlots();
    }

    private void AssignSlots()
    {
        _slot = GameObject.Find("Panel");
        for (int i = 0; i < BirdsName.Count; i++)
        {
            Item.Add(Instantiate(_slot, transform));
            Item[i].transform.GetChild(0).GetComponent<Text>().text = BirdsName[i];
        }
    }
}
