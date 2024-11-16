using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _location; 
    public string _mood;   

    public string Date 
    { 
        get => _date; 
        set => _date = value; 
    }
    
    public string Prompt 
    { 
        get => _prompt; 
        set => _prompt = value; 
    }

    public string Response 
    { 
        get => _response; 
        set => _response = value; 
    }

     public string Location
    {
        get => _location;
        set => _location = value;
    }

    public string Mood
    {
        get => _mood;
        set => _mood = value;
    }

    public Entry(string date, string prompt, string response, string location,string mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _location = location;
        _mood = mood;
    }

    public override string ToString(){
        return ($"{_date}: {_prompt}\nResponse: {_response}\nLocation: {_location}\nMood: {_mood}\n");
    }
    
}