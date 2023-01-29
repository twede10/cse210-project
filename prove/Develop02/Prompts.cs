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
            ,"List three things you're grateful for today"
            ,"Describe a difficult conversation you had and how you handled it"
            ,"Write about a time when you felt proud of yourself"
            ,"Reflect on a time when you learned something new about yourself"
            ,"Describe a person who inspires you and why"
            ,"Write about a time when you felt truly connected to others"
            ,"Reflect on a time when you felt disconnected or alone"
            ,"Describe a moment of beauty you witnessed today"
            ,"Write about a goal you're working towards and how you plan to achieve it"
            ,"Reflect on a time when you showed compassion or empathy towards someone."
        };
        int index = randomPrompt.Next(list.Count);
        return list[index];
    }
}
