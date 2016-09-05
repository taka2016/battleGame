using UnityEngine;
using System.Collections;

public class GameRule : MonoBehaviour {
    private static int player_side = 0;
    private static int enemy_side = 1;

    public GameObject[] players = new GameObject[6];
    public GameObject[] enemys = new GameObject[6];

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //6ターンだけ戦闘を行います。
        for (int i=0;i < 6 ;i++)
        {
            //各ターン、どちらから戦闘を行うかを決めます
            int Game_side = Random.Range(player_side,enemy_side+1);
            Debug.Log("攻撃サイド:" + Game_side);
            //各サイドの攻撃メソッド
            do_side(Game_side);
            //反対側の攻撃サイド
            Game_side = Game_side > player_side ? player_side : enemy_side;
            do_side(Game_side);
        }
	}

    //各攻撃サイドの行動
    void do_side(int side)
    {

    }

    //攻撃
    void do_attack(GameObject attacker,GameObject defence)
    {

    }

    //防御
    void do_defence(GameObject defence)
    {

    }

    //魔法
    void do_magic(GameObject caster,GameObject player)
    {

    }

    //勝利・敗北判定
    bool result_search()
    {
        bool result = true;
        return result;
    }
}
