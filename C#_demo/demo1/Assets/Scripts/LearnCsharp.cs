using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum RoleType {
    Mag,
    Soldier,
    Wizard
}
enum EnemyType {
    Type1,
    Type2,
    Type3,
    Type4
}
public class LearnCsharp : MonoBehaviour {

    // method 方法
	// Use this for initialization
	void Start () {
        //调用方法
        //Test();
        //CreateEnemy();
        //CreateEnemy();

        //int roleType = 0; // 0代表魔法师 1战士 2巫师 3坦克 ..
        //RoleType rt = RoleType.Mag;
        //rt = RoleType.Soldier;

        //CreateEnemy(new Vector3(1, 1, 1));
        //CreateEnemy(new Vector3(3, 3, 4));
        int res = Add(10, 67);
        print(res);
    }

    //定义方法
    void Test() {
        print("Test方法被调用了");
    }

    void CreateEnemy( Vector3 pos ) {
        print("创建敌人");
        print("设置敌人位置"+pos);
        print("设置敌人的初始属性");
    }

    int Add(int a,int b) {
        int res = a + b;
        return res;
    }

    //返回值 方法名(参数) {
    //    方法体
    //}
	
	// Update is called once per frame
	void Update () {
		
	}
}
