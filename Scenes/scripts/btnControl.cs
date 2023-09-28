using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class NewBehaviourScript : MonoBehaviour
{
    public void open1()
    {
        System.Diagnostics.Process.Start("collisions1.exe");
    }

    public void open10()
    {
        System.Diagnostics.Process.Start("collisions10.exe");
    }

    public void open50()
    {
        System.Diagnostics.Process.Start("collisions50.exe");
    }

    public void open100()
    {
        System.Diagnostics.Process.Start("collisions100.exe");
    }
    
    public void open500()
    {
        System.Diagnostics.Process.Start("collisions500.exe");
    }
    
    public void open1000()
    {
        System.Diagnostics.Process.Start("collisions1000.exe");
    }

    public void open10000()
    {
        System.Diagnostics.Process.Start("collisions10000.exe");
    }
}
