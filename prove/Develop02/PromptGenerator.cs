public class PromptGenerator
{
    public List<string> _prompts = new List<string>{"Who did you see today?", "What are your feelings about today?",
    "If you had one thing you could do over today, what would it be?", "What was the best part of your day?", "Do you regret something? what?"};

    public string GetPrompt()
    {
        Random random = new Random();
        int num_ram = random.Next(_prompts.Count);
        return _prompts[num_ram];
    }

}