using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Items
{
    [CreateAssetMenu]
    public class GunWeaponScriptable : Weapon
    {
        public float ReloadSpeed;
        public float MagazineCapacity;
        public float CurrentMagazineSize;
        public GameEvent OnWeaponEmpty;

        public override bool Activate()
        {
            if (CurrentMagazineSize > 0)
            {
                CurrentMagazineSize--;
                return true;
            }
            else
            {
                OnWeaponEmpty.Raise();
                return false;
            }
        }

        public override IEnumerator Reload()
        {
            yield return new WaitForSeconds(ReloadSpeed);
            CurrentMagazineSize = MagazineCapacity;
        }
    }
}