namespace Pol2;

class StandartGrading : IGradeStrategy
{
    public string StrategyName {get;}
    public StandartGrading(string strategyNamme)
    {
        ArgumentException.ThrowIfNullOrEmpty(strategyNamme);
        StrategyName = strategyNamme;
    }
    public double CalculateFinalGrade(string strategyNamme, int examScore, List<int> Asignments)
    {
        if (examScore < 0 || examScore  > 100)
            throw new Exception($"Your examscore can`t be negative");
        return (Asignments.Sum()/Asignments.Count()*0.4) + examScore*0.6;   
    }
}