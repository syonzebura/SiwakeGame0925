using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //ゲームシーンの変数。0：スタート時　１：ゲーム中　２：ゲームクリア時
    public int GameSceneNumber = 0;
    //ゲームシーンのboxの数
    public int boxcount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.boxcount == 0)
        {
            this.GameSceneNumber = 2;
        }
    }

    public void GameSceneCount()
    {
        this.GameSceneNumber++;
    }
    public void BoxBreak()
    {
        this.boxcount--;
    }
}
