using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class MatchesSet_4
{
    private List<GameObject> matchedCandies;

   
    /// Returns distinct list of matched candy
   
    public IEnumerable<GameObject> MatchedCandy
    {
        get
        {
            return matchedCandies.Distinct();
        }
    }

    public void AddObject(GameObject go)
    {
        if (!matchedCandies.Contains(go))
            matchedCandies.Add(go);
    }

    public void AddObjectRange(IEnumerable<GameObject> gos)
    {
        foreach (var item in gos)
        {
            AddObject(item);
        }
    }

    public MatchesSet_4()
    {
        matchedCandies = new List<GameObject>();
        BonusesContained = BonusType_4.None;
    }

    public BonusType_4 BonusesContained { get; set; }
}

