using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public void CreateBullet(Vector3 BulletPosition)
    {
        GameObject gob = Pooling.instance._Pull(gameObject.tag,GetPath(gameObject.tag));
        gob.transform.position = BulletPosition;
        gob.GetComponent<Bullet>().BulletMove(BulletPosition, Vector3.zero);
    }
    string GetPath(string tag)
    {
        switch (tag)
        {
            case "Arrow":
                return "Prefabs/Weapon/ThrowWeapon/Arrow";
            case "Axe_0":
                return "Prefabs/Weapon/ThrowWeapon/AXE0";
            case "Axe_1":
                return "Prefabs/Weapon/ThrowWeapon/AXE1";
            case "boomerang":
                return "Prefabs/Weapon/ThrowWeapon/Boomerang";
            case "candy_0":
                return "Prefabs/Weapon/ThrowWeapon/Candy_0";
            case "candy_1":
                return "Prefabs/Weapon/ThrowWeapon/Candy_1";
            case "candy_2":
                return "Prefabs/Weapon/ThrowWeapon/Candy_2";
            case "candy_4":
                return "Prefabs/Weapon/ThrowWeapon/Candy_4";
            case "Hammer":
                return "Prefabs/Weapon/ThrowWeapon/Hammer";
            case "knife":
                return "Prefabs/Weapon/ThrowWeapon/Knife";
            case "uzi":
                return "Prefabs/Weapon/ThrowWeapon/UZI";
            default:
                return "Prefabs/Weapon/ThrowWeapon/Z";
        }
    }
}