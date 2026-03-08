namespace Pol2;

interface IGradeStrategy
{
    string StrategyName {get;}

    double CalculateFinalGrade(List<int> assignments, int examScore);
}