using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounterBehavior : CheckpointBehaviour
{
    [SerializeField] private int _neededCoins;
    [SerializeField] private CoinCounter _coinCounter;

    // public CoinCounterBehavior(int neededCoins, CoinCounter coinCounter)
    // {
    //     _neededCoins = neededCoins;
    //     _coinCounter = coinCounter;
    // }

    // public override void Init()
    // {
    // }
    public override void OnActivate()
    {
        _coinCounter.SetNeededCoins(_neededCoins);
    }

    public override void OnDeactivate()
    {
        _coinCounter.ResetCoinCounter();
    }
}
