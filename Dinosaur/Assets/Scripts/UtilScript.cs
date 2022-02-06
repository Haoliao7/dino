using UnityEngine;

public class UtilScript
{
    // modify the Vector3 and then return it
    public static Vector3 Vector3Modify(Vector3 Vec, float xMov, float yMov , float zMov)
    {
        Vector3 returnVec = new Vector3(Vec.x + xMov, Vec.y + yMov, Vec.z + zMov); // add xMov to xPos of this Vector3...and so on


        return returnVec; // return it
    }


}