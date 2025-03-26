using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryPattern : MonoBehaviour
{
    [Header("Simple")]
    [SerializeField] private SpawnerMonster monsterSpawner;

    [Header("Method")]
    [SerializeField] private SpawnerSlime slimeSpanwer;
    [SerializeField] private SpawnerMushroom mushroomSpanwer;

    [Header("Abstract")]
    [SerializeField] BossSpawnerBase[] bossSpawnerAry;

    void Start()
    {
        //SimpleFactory 단일클래스에서 객체를 생성하는 패턴
        MonsterBase slime1 = monsterSpawner.SpawnMonster(EMonsterType.Slime);
        MonsterBase mushroom1 = monsterSpawner.SpawnMonster(EMonsterType.Mushroom);

        //MethodFactory 객체생성을 자식클래스에 할당하는 패턴
        MonsterBase redSlime1 = slimeSpanwer.SpawnMonster(ColorType.red);
        MonsterBase greenSlime1 = slimeSpanwer.SpawnMonster(ColorType.green);
        MonsterBase blueSlime1 = slimeSpanwer.SpawnMonster(ColorType.blue);

        MonsterBase redMushroom1 = mushroomSpanwer.SpawnMonster(ColorType.red);
        MonsterBase greenMushroom1 = mushroomSpanwer.SpawnMonster(ColorType.green);
        MonsterBase blueMushroom1 = mushroomSpanwer.SpawnMonster(ColorType.blue);

        //AbstractFactory 연관된 객체를 일관된 방식으로 생성하는 패턴
        MonsterBase slimeBoss1 = bossSpawnerAry[0].SpawnBoss();
        MonsterBase mushroomBoss1 = bossSpawnerAry[1].SpawnBoss();
    }
}
