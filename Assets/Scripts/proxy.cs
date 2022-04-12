using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Proxy;

public class proxy : Proxy
{
    public new const string NAME = "myproxy";
    valuedata mydata = null;
    public proxy():base(NAME)
    {
        mydata = new valuedata();
    }
    
    //对数据操作
    public void addvalue()
    {
        mydata.value++;
        SendNotification("msg_add", mydata);
    }
    public void subvalue()
    {
        mydata.value--;
        SendNotification("msg_sub", mydata);
    }
}
