using System;

public class Score

    public String Name;
    public Int32 Score;
    public Int32 Time;
}
class class1
{
    static void save(String name, int score, int time)
    {
        Score p = new Score();
        p.Name = name;
        p.Score = score;
        p.Time = time;
        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(p.GetType());
        x.Serialize(Console.Out, p);
        Console.WriteLine();
        Console.ReadLine();
    }
}