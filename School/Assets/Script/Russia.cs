using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using UnityEditor;
using System.Reflection;
using System;

public class Russia : MonoBehaviour
{

    public Button Option1, Option2, Option3, Option4;
    public Timer Timer;
    public TextMeshProUGUI History;
    static public TextMeshProUGUI Text1, Text2, Text3, Text4;
    public TextMeshProUGUI Title, Description;
    public Event input;
    public bool TimeStopped = true;
    public bool EventDone = true;
    private Event blank = new Event("", "", "", "","","","","","","","");

    List<Event> Events = new List<Event>();

    // Start is called before the first frame update
    void Start()
    {
        Text1 = Option1.GetComponentInChildren<TextMeshProUGUI>();
        Text2 = Option2.GetComponentInChildren<TextMeshProUGUI>();
        Text3 = Option3.GetComponentInChildren<TextMeshProUGUI>();
        Text4 = Option4.GetComponentInChildren<TextMeshProUGUI>();

        Option1.onClick.AddListener(() => Button1(input));
        Option2.onClick.AddListener(() => Button2(input));
        Option3.onClick.AddListener(() => Button3(input));
        Option4.onClick.AddListener(() => Button4(input));

        Events.Add(new Event("4. April 1949","NATO has Formed", "USA has formed an anti soviet alliance, called NATO, what is our response?", "Ask to Join Nato?", "Be mad", "Get sad", "Start making your own", "USA: NO!","USA: HEHEHEHEHXD","USA: UwU","USA: >.<"));

        TimeStopped = false;
        Timer.currentYear = 1949;
        History.text = "";
    }
    void Update()
    {
        if(Timer.CurrentTime == "4. April 1949")
        {
            RussianTime(input = Events[0]);
        }
    }

    // Update is called once per frame
    void RussianTime(Event ev)
    {
        if(Timer.CurrentTime == ev.Trigger)   
        {
            Title.text = input.Title;
            Description.text = input.Description;
            Text1.text = input.Option1;
            Text2.text = input.Option2;
            Text3.text = input.Option3;
            Text4.text = input.Option4;
            TimeStopped = true;
            EventDone = false;
        }
    }
    void FixedUpdate()
    {
        if (!TimeStopped)
        {
            Timer.UpdateTime(Time.fixedDeltaTime);
        }
        
    }
    public void Button1(Event ev)
    {
        History.text += ev.Description + "\n";
        History.text += ev.Option1 + "\n";
        History.text += "\t" + ev.Response1 + "\n";
        EventDone = true;
        if (Timer.CurrentTime == ev.Trigger && EventDone)
        {
            input = blank;
            Timer.UpdateTime(1);
            TimeStopped = false;
            Title.text = "Response";
            Description.text = ev.Response1;
            Event.RemoveText();
        }    
    }
    public void Button2(Event ev)
    {
        History.text += ev.Description + "\n";
        History.text += ev.Option2 + "\n";
        History.text += "\t" + ev.Response2 + "\n";
        EventDone = true;
        if (Timer.CurrentTime == ev.Trigger && EventDone)
        {
            input = blank;
            Timer.UpdateTime(1);
            TimeStopped = false;
            Title.text = "Response";
            Description.text = ev.Response2;
            Event.RemoveText();
        }
    }
    public void Button3(Event ev)
    {
        History.text += ev.Description + "\n";
        History.text += ev.Option3 + "\n";
        History.text += "\t" + ev.Response3 + "\n";
        EventDone = true;
        if (Timer.CurrentTime == ev.Trigger && EventDone)
        {
            input = blank;
            Timer.UpdateTime(1);
            TimeStopped = false;
            Title.text = "Response";
            Description.text = ev.Response3;
            Event.RemoveText();
        }
    }
    public void Button4(Event ev)
    {
        History.text += ev.Description + "\n";
        History.text += ev.Option4 + "\n";
        History.text += "\t" + ev.Response4 + "\n";
        EventDone = true;
        if (Timer.CurrentTime == ev.Trigger && EventDone)
        {
            input = blank;
            Timer.UpdateTime(1);
            TimeStopped = false;
            Title.text = "Response";
            Description.text = ev.Response4;
            Event.RemoveText();
        }
    }
}

public class Event
{
    public string Trigger { get; set; } 
    public string Title { get; set; }
    public string Description { get; set; }
    public string Response1 { get; set; }
    public string Response2 { get; set; }
    public string Response3 { get; set; }
    public string Response4 { get; set; }
    public string Option1 { get; set; }
    public string Option2 { get; set; }
    public string Option3 { get; set; }
    public string Option4 { get; set; }

    public Event(string trig, string title, string desc, string option1, string response1)
    {
        Trigger = trig;
        Title = title;
        Description = desc;
        Option1 = option1;
        Response1 = response1;

    }
    public Event(string trig, string title, string desc, string option1, string option2, string response1, string response2)
    {
        Trigger = trig;
        Title = title;
        Description = desc;
        Option1 = option1;
        Option2 = option2;
        Response1 = response1;
        Response2 = response2;
    }
    public Event(string trig, string title, string desc, string option1, string option2, string option3, string response1, string response2, string response3)
    {
        Trigger = trig;
        Title = title;
        Description = desc;
        Option1 = option1;
        Option2 = option2;
        Option3 = option3;
        Response1 = response1;
        Response2 = response2;
        Response3 = response3;
    }
    public Event(string trig, string title, string desc, string option1, string option2, string option3, string option4, string response1, string response2, string response3, string response4)
    {
        Trigger = trig;
        Title = title;
        Description = desc;
        Option1 = option1;
        Option2 = option2;
        Option3 = option3;
        Option4 = option4;
        Response1 = response1;
        Response2 = response2;
        Response3 = response3;
        Response4 = response4;
    }

    public static void RemoveText()
    {
        Russia.Text1.text = "";
        Russia.Text2.text = "";
        Russia.Text3.text = "";
        Russia.Text4.text = "";
    }
}
