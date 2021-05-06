using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    Gun equipedGun;
    public Transform weaponHolder;

    public Gun startingGun;
    void Start()
    {
        if (startingGun!=null)
        {
            EquipGun(startingGun);
        }
       
    }

   
    void Update()
    {
        
    }
    public void EquipGun(Gun guntoEquip)
    {
        if (equipedGun!=null)
        {
            Destroy(equipedGun.gameObject);
        }
        equipedGun = Instantiate(guntoEquip, weaponHolder.position, Quaternion.identity) as Gun;
        equipedGun.transform.parent = weaponHolder;
    }
    public void Shoot()
    {
        if (equipedGun!=null)
        {
            equipedGun.Shoot();
        }
    }
}
