using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StageState :MonoBehaviour
{
    public int score = 0;
    public  int lastScore;

}
[Serializable]
public class PlayerStage : MonoBehaviour
{
    public IStage currentStage { get; private set; }
    [SerializeField] FirstStage firstStage;
    [SerializeField] SecondStage secondStage;
    [SerializeField] ThirdStage thirdStage;

    public void StageStart(IStage startingStage)
    {
        currentStage = startingStage;
        startingStage.Enter();
    }
    public void Update()
    {
        if (currentStage != null)
        {
            currentStage.Update();
        }
    }
    public void StageStop(IStage nextStage)
    {
        currentStage = nextStage;
        nextStage.Exit();
    }
    public PlayerStage(PlayerStage stage)
    {
        this.firstStage = new FirstStage(stage);
        this.secondStage = new SecondStage(stage);
        this.thirdStage = new ThirdStage(stage);
    }
}