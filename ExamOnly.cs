namespace Pol2;

class ExamOnlyGrading : IGradeStrategy
{
    public string StrategyName {get; set;}
    public ExamOnlyGrading(string strategyNamme)
    {
        ArgumentException.ThrowIfNullOrEmpty(strategyNamme);
        StrategyName = strategyNamme;
    }
    public double CalculateFinalGrade(string strategyNamme, int examScore, List<int> Asignments)
    {
        return examScore;   
    }
}