namespace StudentGradesManagementSystem
{
    internal static class SharedData
    {
        // 1D arrays
        public static string[] studentIDs = new string[10];
        public static string[] studentNames = new string[10];
        public static string[] courses = { "MIS302", "ICS104", "MATH101", "IAS212", "ENG102" };

        // 2D array: 10 students, 5 courses
        public static int[,] allGrades = new int[10, 5];

        public static int studentCount = 0;
    }
}