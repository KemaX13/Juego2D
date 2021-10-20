using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public ShootingSystemData[] shootingData;
    //public Transform[] shotPoints;
    private ShootingSystem launcher;

    void Awake()
    {
        InputSystemKeyboard sk;
        if (TryGetComponent<InputSystemKeyboard>(out sk))
            sk.OnFire += Shoot;
    }

    void Update()
    {
        var input = Input.inputString;
        if (Input.GetKeyDown(KeyCode.B))
        {
            ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShotData");
            Destroy(gameObject.GetComponent<ShootingSystem>());
            ShotSystem s = gameObject.AddComponent<ShotSystem>();
            s.shootingdata = sh;
            //s.shotPoint = shotPoints[0];
            launcher = s;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShotData");
            Destroy(gameObject.GetComponent<ShootingSystem>());
            MissileSystem m = gameObject.AddComponent<MissileSystem>();
            m.shootingdata = sh;
            //m.shotPoint = shotPoints[0];
            launcher = m;
        }
    }

    void Shoot()
    {
        launcher.Shoot();
    }
}