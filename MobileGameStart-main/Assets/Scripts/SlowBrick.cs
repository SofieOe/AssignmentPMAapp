using UnityEngine;

public class SlowBrick : BaseBrick
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Awake()
    {
        gravityScale= 2f;
    }
}
