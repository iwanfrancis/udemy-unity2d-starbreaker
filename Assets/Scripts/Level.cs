using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    [SerializeField] int breakableBlocks; // Serialized for debug


    public void CountBreakableBlocks() {
        breakableBlocks++;
    }

    public void BlockBroken() {
        breakableBlocks--;
    }
}
