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


        // 1. To store the ID and Name of the person who just logged in
        public static string CurrentUserID = "";
        public static string CurrentUserName = "";

        // 2. To store the calculated GPAs so the Faculty can view them
        public static double[] allGPA = new double[10];
        static SharedData()
        {
            AddDefaultStudent(0, "202311223", "Sara", new int[] { 4, 3, 4, 4, 4 }, 3.80);
            AddDefaultStudent(1, "202199887", "Fahad", new int[] { 2, 2, 1, 0, 2 }, 1.40);
            AddDefaultStudent(2, "202455664", "Layla", new int[] { 4, 4, 3, 4, 2 }, 3.40);
            AddDefaultStudent(3, "202288771", "Khaled", new int[] { 3, 2, 3, 2, 3 }, 2.60);
            AddDefaultStudent(4, "202511442", "Noura", new int[] { 4, 4, 4, 4, 3 }, 3.80);
            AddDefaultStudent(5, "202066339", "Omar", new int[] { 1, 1, 2, 0, 1 }, 1.00);
            studentCount = 6; 
        }

        private static void AddDefaultStudent(int index, string id, string name, int[] grades, double gpa)
        {
            studentIDs[index] = id;
            studentNames[index] = name;
            allGPA[index] = gpa;
            for (int j = 0; j < 5; j++)
            {
                allGrades[index, j] = grades[j];
            }
        }
    }
}