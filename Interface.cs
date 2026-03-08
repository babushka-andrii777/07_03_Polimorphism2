namespace Pol2;

interface IGradeStrategy
{
    string StrategyName {get;} 

    double CalculateFinalGrade(string strategyNamme, int examScore, List<int> Asignments);   
}