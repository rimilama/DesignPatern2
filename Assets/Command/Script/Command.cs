using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    protected float Move = 1f;
    public abstract void Execute(Transform Box);
}

public class Avancer : Command
{
    public override void Execute(Transform Box)
    {
        Box.Translate(Box.forward * Move);
    }
}

public class Reculer : Command
{
    public override void Execute(Transform Box)
    {
        Box.Translate(-Box.forward * Move);
    }
}

public class Droite : Command
{
    public override void Execute(Transform Box)
    {
        Box.Translate(Box.right * Move);
    }
}

public class Gauche : Command
{
    public override void Execute(Transform Box)
    {
        Box.Translate(-Box.right * Move);
    }
}

public class Monter : Command
{
    public override void Execute(Transform Box)
    {
        Box.Translate(Box.up * Move);
    }
}

public class Descndre : Command
{
    public override void Execute(Transform Box)
    {
        Box.Translate(-Box.up * Move);
    }
}