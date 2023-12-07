using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{    
    public List<string> studentsList {get; private set;} = new List<string>(){"Alice","Bob", "Charlie", "David",
                                      "Eve", "Fred", "Ginny", "Harriet",
                                      "Ileana", "Joseph", "Kincaid", "Larry"};
    public List<string> rows {get; private set;} = new List<string>();
    public KindergartenGarden(string diagram)
    {
        rows = new List<string>(diagram.Split('\n'));
    }

    public IEnumerable<Plant> Plants(string student)
    {
        var studentPlants=rows[0].Substring(studentsList.IndexOf(student)*2, 2)+rows[1].Substring(studentsList.IndexOf(student)*2, 2);
        var plantsList=new List<Plant>();
        studentPlants=studentPlants.ToLower();

        foreach(char c in studentPlants){
            switch(c){
                case 'g':
                    plantsList.Add(Plant.Grass);
                    break;
                case 'v':
                    plantsList.Add(Plant.Violets);
                    break;
                case 'c':
                    plantsList.Add(Plant.Clover);
                    break;
                case 'r':
                    plantsList.Add(Plant.Radishes);
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        //plantsList.Sort();
        return plantsList;
    }
}