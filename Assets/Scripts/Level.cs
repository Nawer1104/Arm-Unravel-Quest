using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<Hand> hands;

    public bool Remove(Hand hand)
    {
        if (hands.Count == 3 && hand.number == 3)
        {
            hands.Remove(hand);
            return true;
        }
        else if (hands.Count == 2 && hand.number == 2)
        {
            hands.Remove(hand);
            return true;
        }
        else if (hands.Count == 1 && hand.number == 1)
        {
            hands.Remove(hand);
            return true;
        }

        return false;
    }
}
