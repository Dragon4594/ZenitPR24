using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class StenyAndProhody : MonoBehaviour
{
    public float f=0;
    public int z;//переменная которая хранит проход в котором мы должны появится
    public int r2=0;
    public int r4=0;
    public int r6=0;
    public int r8=0;
    public GameObject play;
    public GameObject camera;
    public GameObject dor;
    public GameObject stena;
    //комната r номер 2 направнение 2 например r22 r22
    public GameObject r18;
    // 2-я комната
    public GameObject r22;
    public GameObject r26;
    public GameObject r24;
    public GameObject r28;
    //3
    public GameObject r32;
    public GameObject r36;
    public GameObject r34;
    public GameObject r38;
    //4
    public GameObject r42;
    public GameObject r46;
    public GameObject r44;
    public GameObject r48;
    

    public static int a=9;//кол-во комнатт на уровне если число 5 то из различных заготовок сгенерируются уровень из 5 
    public static int xkomnat = 4;
    public static int[,] arr = new int [a,a];
    
    public static  int WhereAreGoing(){
        for(int i =0;i<a;i++){//поиск в какой комнате мы находились
                if (arr[0,i]>10){
                //Debug.Log(i);   
                    arr[0,i]=arr[0,i]-10;
                    for(int t =0;t<a;t++){//в какой проход мы вошли в прошлой комнате это значение в массиве увеличиваются в скрипте TeleportInTanel
                        if(arr[t,i]==98){
                            arr[t,i]=arr[t,i]-10;
                            arr[0,t]=arr[0,t]+10;//в какую комнату мы должны попасть по таблице
                            //Debug.Log(arr[0,t]);
                            //Debug.Log(arr[0,t]);
                            //Debug.Log(98);
                            for (int g=0; g<a;g++){
                                if (arr[g,t]==22){
                                    return 22; // в какой проход мы должны попасть
                                }
                                
                            }
                            return 0;
    }
                            
                            
                        
                        if(arr[t,i]==76){
                            arr[t,i]=arr[t,i]-10;
                            arr[0,t]=arr[0,t]+10;
                            //Debug.Log(arr[0,t]);
                            //Debug.Log(76);
                            for (int g=0; g<a;g++){
                                if (arr[g,t]==44){
                                    return 44; // в какой проход мы должны попасть
                                }
                                
                            }
                            return 0;
    }
                            //фыход из процидуры конец массива
                        
                        if(arr[t,i]==54){
                            
                            arr[t,i]=arr[t,i]-10;
                            arr[0,t]=arr[0,t]+10;
                            
                            //Debug.Log(arr[0,t]);
                            //Debug.Log(54);
                            for (int g=0; g<a;g++){
                                if (arr[g,t]==66){
                                    return 66; // в какой проход мы должны попасть
                                }
                                
                            }
                            return 0;
                            }
                            //фыход из процидуры конец массива
                        
                        if(arr[t,i]==32){
                            arr[t,i]=arr[t,i]-10;
                            arr[0,t]=arr[0,t]+10;
                            //Debug.Log(arr[0,t]);
                            //Debug.Log(32);
                            for (int g=0; g<a;g++){
                                if (arr[g,t]==88){
                                    return 88; // в какой проход мы должны попасть
                                }
                                
                            }
                            return 0;
                            }
                            //фыход из процидуры конец массива
                        }
                }
            }
            return 0;
        }
    public void gensten(){
        Destroy(GameObject.Find("Emty22"));
        Destroy(GameObject.Find("Emty88"));
        Destroy(GameObject.Find("Emty44"));
        Destroy(GameObject.Find("Emty66"));
        for (int i=0;i<a;i++){
                if (arr[0,i]>10){//комната в которую мы хотим перейти
                 Debug.Log("y");
                    for(int g=0; g<a;g++){//сделать распознование в какой комнате должны спавнится двери заспавнить двери написать логику спавна стен
                        if(arr[0,i]==11){
                            play.transform.position=r18.transform.position;
                                    play.transform.rotation = Quaternion.Euler(0,90,0);
                                    camera.transform.position=r18.transform.position;
                                    camera.transform.rotation = Quaternion.Euler(0,90,0);
                        }
                        if(arr[0,i]==12){//2-я комната
                            if (arr[g,i]==22){
                                GameObject Empty22 = Instantiate(dor,r22.transform.position,Quaternion.Euler(0,90,0));//спавн кого где
                                Empty22.name="Emty22";
                                
                                r2=1;
                            
                            
                            }
                        ////
                        if (arr[g,i]==44){
                            GameObject Empty44 = Instantiate(dor,r24.transform.position,Quaternion.Euler(0,180,0));//спавн кого где
                            Empty44.name="Emty44";
                            r4=1;
                            
                            
                        }
                        ///
                        if (arr[g,i]==66){
                            GameObject Empty66 = Instantiate(dor,r26.transform.position,Quaternion.Euler(0,0,0));//спавн кого где
                            Empty66.name="Emty66";
                            r6=1;
                           
                            
                        }
                        ///
                        if (arr[g,i]==88){
                            r8=1;
                            GameObject Empty88 = Instantiate(dor,r28.transform.position,Quaternion.Euler(0,90*3,0));//спавн кого где
                            Empty88.name="Emty88";                                                        
                        }

                    }//////////////////
                    if(arr[0,i]==13){//3-я комната
                        if (arr[g,i]==22){
                            GameObject Empty22 = Instantiate(dor,r32.transform.position,Quaternion.Euler(0,90,0));//спавн кого где
                            Empty22.name="Emty22";
                            r2=1; 
                        }
                        ////
                        if (arr[g,i]==44){
                            GameObject Empty44 = Instantiate(dor,r34.transform.position,Quaternion.Euler(0,180,0));//спавн кого где
                            Empty44.name="Emty44";
                            r4=1;
                        }
                        ///
                        if (arr[g,i]==66){
                            GameObject Empty66 = Instantiate(dor,r36.transform.position,Quaternion.Euler(0,0,0));//спавн кого где
                            Empty66.name="Emty66";
                            r6=1; 
                        }
                        ///
                        if (arr[g,i]==88){
                            GameObject Empty88 = Instantiate(dor,r38.transform.position,Quaternion.Euler(0,90*3,0));//спавн кого где
                            Empty88.name="Emty88";
                            r8=1;
                            
                        }

                    }
                    /////////
                    ///
                    if(arr[0,i]==14){//4-я комната
                        if (arr[g,i]==22){
                            GameObject Empty22 = Instantiate(dor,r42.transform.position,Quaternion.Euler(0,90,0));//спавн кого где
                            Empty22.name="Emty22";
                            r2=1;
                        }
                        ////
                        if (arr[g,i]==44){
                            GameObject Empty44 = Instantiate(dor,r44.transform.position,Quaternion.Euler(0,180,0));//спавн кого где
                            Empty44.name="Emty44";
                            r4=1;
                        }
                        ///
                        if (arr[g,i]==66){
                            GameObject Empty66 = Instantiate(dor,r46.transform.position,Quaternion.Euler(0,0,0));//спавн кого где
                            Empty66.name="Emty66";
                            r6=1;
                        }
                        ///
                        if (arr[g,i]==88){
                            GameObject Empty88 = Instantiate(dor,r48.transform.position,Quaternion.Euler(0,90*3,0));//спавн кого где
                            Empty88.name="Emty88";
                            r8=1; 
                        }

                        }
                       ////////////////////////////////////////////////////// 
                        
                    }
                    }
                    if(arr[0,i]==12){
                        
                        if(r2==0){
                            GameObject Empty22 = Instantiate(stena,r22.transform.position,Quaternion.Euler(90,270,0));
                            Empty22.name="Emty22";
                        }
                        if(r4==0){
                            GameObject Empty44 = Instantiate(stena,r24.transform.position,Quaternion.Euler(90,0,0));
                            Empty44.name="Emty44";
                        }
                        if(r6==0){
                            
                            GameObject Empty66 = Instantiate(stena,r26.transform.position,Quaternion.Euler(90,180,0));
                            Empty66.name="Emty66";
                        }
                        if(r8==0){
                            GameObject Empty88 = Instantiate(stena,r28.transform.position,Quaternion.Euler(90,90,0));
                            Empty88.name="Emty88";
                        }
                    }

                    if(arr[0,i]==13){
                        if(r2==0){
                            GameObject Empty22 = Instantiate(stena,r32.transform.position,Quaternion.Euler(90,270,0));
                            Empty22.name="Emty22";
                        }
                        if(r4==0){
                            GameObject Empty44 = Instantiate(stena,r34.transform.position,Quaternion.Euler(90,0,0));
                            Empty44.name="Emty44";
                        }
                        if(r6==0){
                            GameObject Empty66 = Instantiate(stena,r36.transform.position,Quaternion.Euler(90,180,0));
                            Empty66.name="Emty66";
                        }
                        if(r8==0){
                            GameObject Empty88 = Instantiate(stena,r38.transform.position,Quaternion.Euler(90,90,0));
                            Empty88.name="Emty88";
                        }
                    }
                    if(arr[0,i]==14){
                        if(r2==0){
                            GameObject Empty22 = Instantiate(stena,r42.transform.position,Quaternion.Euler(90,270,0));
                            Empty22.name="Emty22";
                        }
                        if(r4==0){
                            GameObject Empty44 = Instantiate(stena,r44.transform.position,Quaternion.Euler(90,0,0));
                            Empty44.name="Emty44";
                        }
                        if(r6==0){
                            GameObject Empty66 = Instantiate(stena,r46.transform.position,Quaternion.Euler(90,180,0));
                            Empty66.name="Emty66";
                        }
                        if(r8==0){
                            GameObject Empty88 = Instantiate(stena,r48.transform.position,Quaternion.Euler(90,90,0));
                            Empty88.name="Emty88";
                        }
                    }
                    r2=0;
                    r4=0;
                    r6=0;
                    r8=0;
                    
                
            }
            ///телепортация игрока
            if (z==22){
                play.transform.position=GameObject.Find("Emty22").transform.position;
                play.transform.rotation = Quaternion.Euler(0,90,0);
                camera.transform.position=GameObject.Find("Emty22").transform.position;
                camera.transform.rotation = Quaternion.Euler(0,90,0);
            }
            if (z==44){
                play.transform.position=GameObject.Find("Emty44").transform.position;
                play.transform.rotation = Quaternion.Euler(0,90,0);
                camera.transform.position=GameObject.Find("Emty44").transform.position;
                camera.transform.rotation = Quaternion.Euler(0,90,0);
            }
            if (z==66){
                play.transform.position=GameObject.Find("Emty66").transform.position;
                play.transform.rotation = Quaternion.Euler(0,90,0);
                camera.transform.position=GameObject.Find("Emty66").transform.position;
                camera.transform.rotation = Quaternion.Euler(0,90,0);
                Debug.Log("emty66");
            }
            if (z==88){
                play.transform.position=GameObject.Find("Emty88").transform.position;
                play.transform.rotation = Quaternion.Euler(0,90,0);
                camera.transform.position=GameObject.Find("Emty88").transform.position;
                camera.transform.rotation = Quaternion.Euler(0,90,0);
            }
            
    }
    //22 s
    //44 a
    //66 d
    //88 w
    public int tt=1;
     public void OnTriggerStay (Collider other){///переписать что в arr[x,y] х а что у?
        if ((other.gameObject.name=="Player")&(Input.GetKey(KeyCode.R))){
                f=f+Time.deltaTime;
        }
        if((f>3.0)&(other.gameObject.name=="Player")){
            
            z=WhereAreGoing();// переход в другую комнату в массиве мы  знаем в какую дверь должны прийти  оно хранится в z
           
            //////генерация стен в комнате 
            gensten();
            
            /*GameObject.Find("Main Camera").transform.position=camera.transform.position+new Vector3(0,0,0);
            GameObject.Find("Main Camera").transform.position=new Vector3(0,0,0);
            Debug.Log("yes");
            camera.transform.rotation = Quaternion.Euler(0,90,0);*/
            /*for(int i=0;i<6;i++){
                for(int t=0;t<6;t++){
                    Debug.Log(arr[i,t]);
                }
                Debug.Log("--------------");
            }Debug.Log("========");*/
            
            

        }
        if(TextDor.q==0){
             tt=1;
        }
     }
     
    //
    // Start is called before the first frame update
    public void Start()
    {
        System.Random random = new System.Random();

        // Создаем массив
        int[,] mas = new int[a, a];

        // Инициализируем первый ряд и первый столбец
        for (int i = 0; i < a - 1; i++)
        {
            mas[0, i] = random.Next(2,xkomnat+1);
            mas[i, 0] = mas[0, i];
        }

        mas[0, 0] = 0;

        // Заполняем границы массива значениями
        for (int i = 1; i < a; i++)
        {
            mas[i, a - 1] = 7;
            mas[a - 1, i] = 7;
            if (i == 1)
            {
                mas[i, a - 1] = 1;
                mas[a - 1, i] = 1;
            }
        }

        mas[0, 1] = 11;
        mas[1, 0] = 1;
        mas[a - 1, a - 1] = 0;

        

        // Логика модификации массива
        for (int i = 1; i < a - 1; i++)
        {
            for (int t = 1; t < a - 1; t++)
            {
                if (mas[i, a - 1] > 0 && mas[a - 1, t] > 0 && mas[i, t] == 0 && i != t)
                {
                    mas[i, t] = random.Next(1, 5);
                    mas[i, a - 1]--;
                    mas[a - 1, t]--;

                    if (mas[i, t] > 0)
                    {
                        switch (mas[i, t])
                        {
                            case 1:
                                mas[i, t] = 22;
                                mas[t, i] = 88;
                                mas[t, a - 1]--;
                                mas[a - 1, i]--;
                                break;
                            case 2:
                                mas[i, t] = 44;
                                mas[t, i] = 66;
                                mas[t, a - 1]--;
                                mas[a - 1, i]--;
                                break;
                            case 3:
                                mas[i, t] = 88;
                                mas[t, i] = 22;
                                mas[t, a - 1]--;
                                mas[a - 1, i]--;
                                break;
                            case 4:
                                mas[i, t] = 66;
                                mas[t, i] = 44;
                                mas[t, a - 1]--;
                                mas[a - 1, i]--;
                                break;
                        }
                    }
                }
            }
        }

        // Вывод и модификация значений
        for (int i = 1; i < a - 1; i++)
        {
            for (int t = 1; t < a - 1; t++)
            {
                for (int g = 1; g < a - 1; g++)
                {
                    if (mas[i, g] == mas[i, t] && g != t && mas[i, t] != 0 && mas[i, g] != 0)
                    {
                        Console.WriteLine($"{mas[i, g]} {mas[i, t]} {i} {t} {g} '1'");
                        mas[i, g] = 0;
                        mas[g, i] = 0;
                    }
                }
            }
        }

        for (int i = 1; i < a - 1; i++)
        {
            for (int t = 1; t < a - 1; t++)
            {
                for (int g = t; g < a - 2; g++)
                {
                    if (mas[i, g + 1] != 0 && mas[i, g] != 0)
                    {
                        mas[i, g + 1] = 0;
                        mas[g + 1, i] = 0;
                        Console.WriteLine($"{i} {g + 1} {t}");
                    }
                    if (mas[i, g] != 0 && mas[i, g + 2] == 0 && i != g + 2)
                    {
                        if (g + 3 < a - 2 && mas[i, g + 3] != 0)
                        {
                            mas[i, g + 2] = mas[i, g + 3];
                            mas[i, g + 3] = 0;
                            mas[g + 2, i] = mas[g + 3, i];
                            mas[g + 3, i] = 0;
                        }
                    }
                }
            }
        }
    // Вывод второй раз
        for (int i = 1; i < a - 1; i++)
        {
            for (int t = 1; t < a - 1; t++)
            {
                for (int g = 1; g < a - 1; g++)
                {
                    if (mas[i, g] == mas[i, t] && g != t && mas[i, t] != 0 && mas[i, g] != 0)
                    {
                        Console.WriteLine($"{mas[i, g]} {mas[i, t]} {i} {t} {g} '1'");
                        mas[i, g] = 0;
                        mas[g, i] = 0;
                    }
                }
            }
        }
    for (int i=0;i<a-2;i++){
        for (int t=0;t<a-2;t++){
            arr[i,t]=mas[i,t];
    }}
    
    
    arr[0,0]=0;
    arr[0,1]=11;
    arr[0,2]=2;
    arr[0,3]=3;
    arr[0,4]=4;
    arr[0,5]=3;
    
    arr[1,0]=1;
    arr[2,0]=2;
    arr[3,0]=3;
    arr[4,0]=4;
    arr[5,0]=3;

    arr[1,1]=0;
    arr[1,2]=22;
    arr[1,3]=0;
    arr[1,4]=0;
    arr[1,5]=0;

    arr[2,1]=88;
    arr[2,2]=0;
    arr[2,3]=22;
    arr[2,4]=00;
    arr[2,5]=66;

    arr[3,1]=0;
    arr[3,2]=88;
    arr[3,3]=0;
    arr[3,4]=0;
    arr[3,5]=0;

    arr[4,1]=0;
    arr[4,2]=00;
    arr[4,3]=0;
    arr[4,4]=0;
    arr[4,5]=88;

    arr[5,1]=0;
    arr[5,2]=44;
    arr[5,3]=0;
    arr[5,4]=22;
    arr[5,5]=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(f>0){
            f=f+Time.deltaTime*2;
        }
        if (f>=3.1){
            f=0;
            if (z==22){
                play.transform.position=GameObject.Find("Emty22").transform.position;
                play.transform.rotation = Quaternion.Euler(0,90,0);
                camera.transform.position=GameObject.Find("Emty22").transform.position;
                camera.transform.rotation = Quaternion.Euler(0,90,0);
            }
            if (z==44){
                play.transform.position=GameObject.Find("Emty44").transform.position;
                play.transform.rotation = Quaternion.Euler(0,90,0);
                camera.transform.position=GameObject.Find("Emty44").transform.position;
                camera.transform.rotation = Quaternion.Euler(0,90,0);
            }
            if (z==66){
                play.transform.position=GameObject.Find("Emty66").transform.position;
                play.transform.rotation = Quaternion.Euler(0,90,0);
                camera.transform.position=GameObject.Find("Emty66").transform.position;
                camera.transform.rotation = Quaternion.Euler(0,90,0);
                Debug.Log("emty66");
            }
            if (z==88){
                play.transform.position=GameObject.Find("Emty88").transform.position;
                play.transform.rotation = Quaternion.Euler(0,90,0);
                camera.transform.position=GameObject.Find("Emty88").transform.position;
                camera.transform.rotation = Quaternion.Euler(0,90,0);
            }
        }
    }
}
