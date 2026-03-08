namespace Pol2;

class StandartGrading : IGradeStrategy
{
    public string StrategyName {get;}
    public int examScore{get; set;}
    public List<int> asignments {get; set;}

    public double CalculateFinalGrade()
    {
        return (asignments.Sum()/asignments.Count()*0.4) + examScore*0.6;
    }
}