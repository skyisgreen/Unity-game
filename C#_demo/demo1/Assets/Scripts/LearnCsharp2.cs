using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCsharp2 : MonoBehaviour {

    void Start() {
        int hp = 100;
        //利用类声明的变量，可以叫做对象
        //Enemy enemy1 = new Enemy();//构造对象
        //Enemy enemy1 = null;
        //print(enemy1);
        Enemy enemy1 = new Enemy();
        print(enemy1.name);
        print(enemy1.hp);
        enemy1.name = "玛丽";
        print(enemy1.name);

        Enemy enemy2 = new Enemy();
        enemy2.name = "小二";
        print(enemy1.name + " - " + enemy2.name);

        enemy1.Move();
        enemy2.Move();
    }

    private void Update() {
        
    }
}


class Enemy {
    public string name;//public的字段才可以通过对象访问
    public int hp;

    public void Move() {
        Debug.Log(name + "正在移动");
    }

    public void Attack() {
        Debug.Log("正在攻击");
    }
}