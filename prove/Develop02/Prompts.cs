public class Prompts
{

    public string GetRandomPrompt()
    {
        var randomPrompt = new Random();
        var list = new List<string>
        {
            "Reflect on a time when you overcame a fear or obstacle"
            ,"Write about a person who has had a significant impact on your life"
            ,"Describe a moment of pure joy or happiness"
            ,"Think about a decision you made that you now regret and explore your emotions surrounding it"
            ,"Write about a place that holds a special meaning to you"
            ,"Think about a time when you felt truly content and explain why"
            ,"Describe an act of kindness you witnessed or experienced"
            ,"Write about a challenge you faced and how you overcame it"
            ,"Reflect on a mistake you made and what you learned from it"
            ,"Describe a person, place, or thing that makes you feel nostalgic."
        };
        int index = randomPrompt.Next(list.Count);
        return list[index];
    }
}
