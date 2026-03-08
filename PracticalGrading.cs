namespace Pol2;

class PracticalGrading : IGradeStrategy
{
    public string StrategyName {get;}
    public PracticalGrading(string strategyNamme)
    {
        ArgumentException.ThrowIfNullOrEmpty(strategyNamme);
        StrategyName = strategyNamme;
    }
    public double CalculateFinalGrade(string strategyNamme, int examScore, List<int> Asignments)
    {
        return (Asignments.Sum()/Asignments.Count()*0.8) + examScore*0.2;   
    }
}