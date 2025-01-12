using System;
using System.Collections.Generic;


public class PromptGenerator{
    public List<string> _prompts;

    public string GetRandomPrompt(){
        Random random = new Random();
        int random1 = random.Next(_prompts.Count);

        return _prompts[random1];
    }
}