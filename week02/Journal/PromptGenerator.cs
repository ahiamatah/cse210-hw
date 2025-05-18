public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What made you smile today?",
        "What are you grateful for?",
        "What is something you learned today?",
        "Describe a challenge you faced today.",
        "Write about something kind you saw or did."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
