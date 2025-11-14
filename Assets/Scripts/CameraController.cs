using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // target = player

    private float zOffset = -10f; // Kameranin Z pozisyonu 
    void LateUpdate() // LateUpdate, Update'den sonra caðrilir, bu yuzden oyuncunun hareketi tamamlandiktan sonra kamerayi guncelleyebiliriz.
    {
        // Eðer bir hedef (target) atamadiysak, hata vermesin diye dur.
        if (target == null)
        {
            return;
        }

        // Kameranin yeni pozisyonunu ayarla:
        // X pozisyonu: Hedefin (Player) X pozisyonu olsun.
        // Y pozisyonu: Hedefin (Player) Y pozisyonu olsun (Ziplarken de takip etsin).
        // Z pozisyonu: Bizim belirlediðimiz zOffset (-10) olsun.
        transform.position = new Vector3(target.position.x, target.position.y, zOffset);
    }
}