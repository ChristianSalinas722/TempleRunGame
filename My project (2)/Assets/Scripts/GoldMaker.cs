using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMaker : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject goldPrefab;

    void Start(){
       GenerateGoldR();
       GenerateProjectilesR();
    }
    
    void Update(){

    }
    void GenerateProjectilesR(){
        StartCoroutine(GenertateProjectiles());
    }
    void GenerateGoldR(){
        StartCoroutine(GenertateGold());
    }
    IEnumerator GenertateGold(){
        while(true){
            Vector2 radomPosition = new Vector2(Random.Range(-3.61f,2.33f),6.75f);
            float randomNum = Random.Range(1f,2f);
            yield return new WaitForSeconds(randomNum);
            yield return null;
        //yield return new WaitForSeconds(4);
        //yield return null;
        //yield return new WaitForSeconds(Time.fixedDeltaTime);
            GameObject newG = Instantiate(goldPrefab,radomPosition,Quaternion.identity);
            Destroy(newG, 4);
        }
    }
    IEnumerator GenertateProjectiles(){
       
        while(true){
            Vector2 radomPosition = new Vector2(Random.Range(-3.61f,2.33f),6.75f);
            float randomNum = Random.Range(1f,2f);
            yield return new WaitForSeconds(randomNum);
            yield return null;
        //yield return new WaitForSeconds(4);
        //yield return null;
        //yield return new WaitForSeconds(Time.fixedDeltaTime);
            GameObject newP = Instantiate(projectilePrefab,radomPosition,Quaternion.identity);
            Destroy(newP, 4);
        }
    }
}
