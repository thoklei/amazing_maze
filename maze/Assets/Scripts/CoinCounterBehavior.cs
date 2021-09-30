using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The behaviour that (de)activates all cannons
public class CoinCounterBehavior : CheckpointBehaviour
{
    private int _neededCoins;
    private CoinCounter _coinCounter;

    public CoinCounterBehavior(int neededCoins, CoinCounter coinCounter)
    {
        _neededCoins = neededCoins;
        _coinCounter = coinCounter;
    }

    public override void Init()
    {
    }
    public override void OnActivate()
    {
        _coinCounter.SetNeededCoins(_neededCoins);
    }

    public override void OnDeactivate()
    {
        _coinCounter.ResetCoinCounter();
    }
}
