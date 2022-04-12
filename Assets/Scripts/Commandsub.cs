using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Command;
using PureMVC.Interfaces;

public class Commandsub : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        proxy proxy = (proxy)Facade.RetrieveProxy(proxy.NAME);
        proxy.subvalue();
    }
}
