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
        //SimpleFactory ����Ŭ�������� ��ü�� �����ϴ� ����
        MonsterBase slime1 = monsterSpawner.SpawnMonster(EMonsterType.Slime);
        MonsterBase mushroom1 = monsterSpawner.SpawnMonster(EMonsterType.Mushroom);

        //MethodFactory ��ü������ �ڽ�Ŭ������ �Ҵ��ϴ� ����
        MonsterBase redSlime1 = slimeSpanwer.SpawnMonster(ColorType.red);
        MonsterBase greenSlime1 = slimeSpanwer.SpawnMonster(ColorType.green);
        MonsterBase blueSlime1 = slimeSpanwer.SpawnMonster(ColorType.blue);

        MonsterBase redMushroom1 = mushroomSpanwer.SpawnMonster(ColorType.red);
        MonsterBase greenMushroom1 = mushroomSpanwer.SpawnMonster(ColorType.green);
        MonsterBase blueMushroom1 = mushroomSpanwer.SpawnMonster(ColorType.blue);

        //AbstractFactory ������ ��ü�� �ϰ��� ������� �����ϴ� ����
        MonsterBase slimeBoss1 = bossSpawnerAry[0].SpawnBoss();
        MonsterBase mushroomBoss1 = bossSpawnerAry[1].SpawnBoss();
    }
}
