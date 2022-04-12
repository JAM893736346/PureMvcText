using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Facade;
public class FacadeA : Facade
{
    public FacadeA(Transform root)
    {
        RegisterCommand("cmd_add", () => { return new Command(); });
        RegisterCommand("cmd_sub", () => { return new Commandsub(); });
        RegisterMediator(new mediator(root));
        RegisterProxy(new proxy());
    }
}
