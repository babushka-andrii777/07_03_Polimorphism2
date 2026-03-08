using Pol2;

class GradeBookManager
{
    private Dictionary<string, IGradeStrategy> _strategies = new();

    public void RegisterStrategy(string courseCode, IGradeStrategy gradeStrategy)
    {
        _strategies[courseCode] = gradeStrategy;
    }

    public double GetStudentScore(string courseCode, int examScore, List<int> Asignments)
    {
        if (_strategies[courseCode] == null)
            throw new KeyNotFoundException($"There is no such course");
        var strategy = _strategies[courseCode];
        return strategy.CalculateFinalGrade(strategy.StrategyName, examScore, Asignments);
    }
}   