using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Mediator;
using UnityEngine.UI;
using PureMVC.Interfaces;

public class mediator : Mediator
{
    public new const string NAME = "Mymediator";
    public Text text;
    public Button addbtn;
    public Button subbtn;
    public mediator(Transform root) : base(NAME)
    {
        text = root.Find("Text").GetComponent<Text>();
        addbtn = root.Find("Add").GetComponent<Button>();
        subbtn = root.Find("Sub").GetComponent<Button>();

        addbtn.onClick.AddListener(BtnClick);
        subbtn.onClick.AddListener(BtnClickSub);

    }
    public override void HandleNotification(INotification notification)
    {
        Debug.Log(notification.Name);
        switch (notification.Name)
        {
            case "msg_add":
                display(notification.Body as valuedata);
                break;
            case "msg_sub":
                display(notification.Body as valuedata);
                break;
        }
    }
    public void display(valuedata mydata)
    {
       // Debug.Log("Ω¯»Îdisplay");
        text.text = mydata.value.ToString();
        //Debug.Log("chu»Îdisplay");
    }
    public override string[] ListNotificationInterests()
    {
        string[] list = new string[2];
        list[0] = "msg_add";
        list[1] = "msg_sub";
        return list;
    }
    public void BtnClick()
    {
        SendNotification("cmd_add");
    }
    public void BtnClickSub()
    {
        SendNotification("cmd_sub");
    }
}
