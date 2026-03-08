namespace Pol2;

class Program 
{
    static void Main()
    {
        var coolStrat = new StandartGrading("Standart Cool Strategy");
        var coolerStrat = new PracticalGrading("Practical Cooler Strategy");
        var wowStrat = new ExamOnlyGrading("Exam only wow strat");

        var gradeManager = new GradeBookManager();

        gradeManager.RegisterStrategy("code228", coolStrat);
        gradeManager.RegisterStrategy("code777", coolerStrat);
        gradeManager.RegisterStrategy("code123", wowStrat);

        Console.WriteLine(gradeManager.GetStudentScore("code228", 89, [68, 87, 43, 77]));
        Console.WriteLine(gradeManager.GetStudentScore("code777", 89, [68, 87, 43, 77]));
        Console.WriteLine(gradeManager.GetStudentScore("code123", 89, [68, 87, 43, 77]));
    }


}

