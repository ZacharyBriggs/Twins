using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    public enum ItemSlotType
    {
        Helmet, LeftArm, RightArm, LeftLeg, RightLeg, Chest
    }
    [CreateAssetMenu]
    public class Item : ScriptableObject
    {
        public string Name;
        public ItemSlotType SlotType;
    }
}
