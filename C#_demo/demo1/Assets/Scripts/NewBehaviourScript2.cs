using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace 

public class NewBehaviourScript2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // ctrl + k ctrl + c
        //print(1); // （） () ; ；
        //print("234234");
        //Debug.Log(1);
        //Debug.Log("23423");

        //Debug.LogWarning("23423");

        //Debug.LogError("23423");

        // 变量
        // 赋值 =  把右边的值赋值给左边的变量
        //int hp = 100; // int hp; 声明变量
        //hp = 90;
        //print(hp);
        //print(100);
        //int hp;//  数据类型 变量名;
        //hp = 100;//初始化
        ////hp = 1.1; // 小数 浮点类型
        //print(hp);
        //long mp = 1000;


        //数据类型
        //int hp = 100;
        //float hp2 = 3.4f;// double float
        //bool isDie = true;// true false
        //char c = 'c';
        //string name = "绝地战士";

        //+ - * /

        //int a = 92;int b = 10;
        //int res = a + b;
        //print(res);
        //int res1 = a - b;
        //int res2 = a * b;
        //int res3 = a / b;//两个整数相除，小数部分会被自动舍去
        //print(res1);
        //print(res2);
        //print(res3);
        //float res4 = 3 + 3.2f;//多个数据类型运算，返回的结果类型是数据类型大的

        //string str1 = "my name is";
        //string str2 = " siki";
        //string strRes = str1 + str2;
        //print(strRes);

        //比较运算符
        // > < >= <= == !=  操作数1 运算符 操作数2
        //int hp = 100;
        //bool res = hp>0;
        //print(res);

        //int hp = 100;
        //hp = hp + 10;
        //hp += 10;
        //print(hp);

        //hp -= 100; // hp = hp-100;
        //print(hp);

        //hp++;// hp = hp + 1;
        //print(hp);
        //hp--;
        //print(hp);

        //int hp = 90;

        //if (hp <= 0)
        //{
        //    print("播放死亡动画");
        //}
        //else
        //{
        //    print("播放行走动画");
        //}

        // 数组   类型[] 数组名 = {数组值}
        //int hp = 100;
        //1,
        //int[] hps = { 100, 20, 80, 90, 30 };//数组长度为5
        //int[] hps2 = { };
        //通过索引来访问数据 0 数组名[索引]
        //print(hps[1]);
        //print(hps[-1]);
        //hps[1] = 50;
        //print(hps[1]);
        //2
        //int[] hps = new int[10];
        //print(hps[0]);
        //int[] hps = null;
        //int[] hps2 = { };
        //print(hps);
        //print(hps2);
        //3
        //int[] hps = new int[5] { 34, 2, 324, 3 ,34};

        //for循环

        //print("创建了一个敌人");
        //for(int i = 1; i <= 10; i++) {
        //    // 循环体
        //    print("创建了一个敌人"+i);
        //}
        //for(int i = 1; i <= 100; i++) {
        //    print("创建敌人");
        //}
        //for(int i = 0; i < 10; i++) {
        //    print("创建敌人");
        //}


        int[] hps = new int[8]{ 10102, 2, 2, 32, 3, 2, 312, 3 };

        //for(int i = 0; i < 8; i++) {
        //    // i = 0 1 2 3 ... 7
        //    print(hps[i]);
        //}
        //通过Length可以访问到数组长度
        for(int i =0;i< hps.Length ; i++) {
            print(hps[i]);
        }
    } 
    
	// Update is called once per frame
	void Update () {
        //print(2);
    }
}
