namespace TASKLEC99
    {
        enum Level { Easy = 1, Medium = 2, Hard = 3 }
        enum QuestionType { TrueFalse = 1, ChooseOne = 2, MultipleChoice = 3 }

        abstract class Question
        {
            public string Header { get; set; }
            public int Marks { get; set; }
            public Level Level { get; set; }
            public abstract void Display();
            public abstract bool CheckAnswer(string input);
        }

        class TrueFalseQuestion : Question
        {
            public bool Correct { get; set; }
            public override void Display()
            {
                Console.WriteLine(Header);
                Console.WriteLine("1) True");
                Console.WriteLine("2) False");
            }
            public override bool CheckAnswer(string input)
            {
                input = input.Trim().ToLower();
                bool ans = input == "1" || input == "t" || input == "true";
                if (input == "2" || input == "f" || input == "false") ans = false;
                return ans == Correct;
            }
        }

        class ChooseOneQuestion : Question
        {
            public List<string> Choices { get; set; } = new List<string>();
            public int CorrectIndex { get; set; }
            public override void Display()
            {
                Console.WriteLine(Header);
                for (int i = 0; i < Choices.Count; i++) Console.WriteLine($"{i + 1}) {Choices[i]}");
            }
            public override bool CheckAnswer(string input)
            {
                if (int.TryParse(input.Trim(), out int idx)) return idx == CorrectIndex;
                var map = new Dictionary<string, int> { { "a", 1 }, { "b", 2 }, { "c", 3 }, { "d", 4 } };
                input = input.Trim().ToLower();
                if (map.ContainsKey(input)) return map[input] == CorrectIndex;
                return false;
            }
        }

        class MultipleChoiceQuestion : Question
        {
            public List<string> Choices { get; set; } = new List<string>();
            public HashSet<int> CorrectIndices { get; set; } = new HashSet<int>();
            public override void Display()
            {
                Console.WriteLine(Header);
                for (int i = 0; i < Choices.Count; i++) Console.WriteLine($"{i + 1}) {Choices[i]}");
                Console.WriteLine("Enter all correct choices separated by commas");
            }
            public override bool CheckAnswer(string input)
            {
                var parts = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var set = new HashSet<int>();
                foreach (var p in parts) if (int.TryParse(p.Trim(), out int v)) set.Add(v);
                return set.SetEquals(CorrectIndices);
            }
        }

        static class App
        {
            static readonly List<Question> Bank = new List<Question>();
            public static void Run()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Examination System");
                    Console.WriteLine("1) Doctor Mode");
                    Console.WriteLine("2) Student Mode");
                    Console.WriteLine("3) Exit");
                    int choice = ReadInt("Choose: ", 1, 3);
                    if (choice == 1) DoctorMode();
                    else if (choice == 2) StudentMode();
                    else return;
                }
            }

            static void DoctorMode()
            {
                Console.Clear();
                int n = ReadInt("Number of questions to add: ", 1, 1000);
                for (int i = 0; i < n; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Adding Question {i + 1} of {n}");
                    var qt = (QuestionType)ReadInt("Type (1 True/False, 2 Choose One, 3 Multiple Choice): ", 1, 3);
                    var lvl = (Level)ReadInt("Level (1 Easy, 2 Medium, 3 Hard): ", 1, 3);
                    string header = ReadNonEmpty("Header: ");
                    int marks = ReadInt("Marks: ", 1, 1000);
                    if (qt == QuestionType.TrueFalse)
                    {
                        bool corr = ReadInt("Correct answer (1 True, 2 False): ", 1, 2) == 1;
                        Bank.Add(new TrueFalseQuestion { Header = header, Marks = marks, Level = lvl, Correct = corr });
                    }
                    else if (qt == QuestionType.ChooseOne)
                    {
                        var choices = ReadChoices(4);
                        int corr = ReadInt("Correct choice number (1-4): ", 1, 4);
                        Bank.Add(new ChooseOneQuestion { Header = header, Marks = marks, Level = lvl, Choices = choices, CorrectIndex = corr });
                    }
                    else
                    {
                        var choices = ReadChoices(4);
                        var corr = ReadMultiCorrect(1, 4);
                        Bank.Add(new MultipleChoiceQuestion { Header = header, Marks = marks, Level = lvl, Choices = choices, CorrectIndices = corr });
                    }
                    Console.WriteLine("Saved. Press any key to continue...");
                    Console.ReadKey(true);
                }
            }

            static void StudentMode()
            {
                Console.Clear();
                if (Bank.Count == 0)
                {
                    Console.WriteLine("No questions available. Press any key to return...");
                    Console.ReadKey(true);
                    return;
                }
                int et = ReadInt("Exam Type (1 Practical, 2 Final): ", 1, 2);
                var lvl = (Level)ReadInt("Level (1 Easy, 2 Medium, 3 Hard): ", 1, 3);
                var pool = Bank.Where(q => q.Level == lvl).ToList();
                if (pool.Count == 0)
                {
                    Console.WriteLine("No questions for the selected level. Press any key to return...");
                    Console.ReadKey(true);
                    return;
                }
                int count = et == 1 ? Math.Max(1, pool.Count / 2) : pool.Count;
                var exam = pool.Take(count).ToList();
                int total = exam.Sum(q => q.Marks);
                int score = 0;
                for (int i = 0; i < exam.Count; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Question {i + 1} of {exam.Count}  |  Marks: {exam[i].Marks}");
                    exam[i].Display();
                    Console.Write("Answer: ");
                    string ans = Console.ReadLine() ?? string.Empty;
                    if (exam[i].CheckAnswer(ans)) score += exam[i].Marks;
                }
                Console.Clear();
                Console.WriteLine($"Your Result: {score} / {total}");
                Console.WriteLine("Press any key to return to main menu...");
                Console.ReadKey(true);
            }

            static int ReadInt(string prompt, int min, int max)
            {
                while (true)
                {
                    Console.Write(prompt);
                    var s = Console.ReadLine();
                    if (int.TryParse(s, out int v) && v >= min && v <= max) return v;
                    Console.WriteLine($"Enter a number between {min} and {max}.");
                }
            }

            static string ReadNonEmpty(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    var s = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(s)) return s.Trim();
                    Console.WriteLine("Value cannot be empty.");
                }
            }

            static List<string> ReadChoices(int count)
            {
                var list = new List<string>();
                for (int i = 1; i <= count; i++) list.Add(ReadNonEmpty($"Choice {i}: "));
                return list;
            }

            static HashSet<int> ReadMultiCorrect(int min, int max)
            {
                while (true)
                {
                    Console.Write($"Enter correct answers as numbers separated by commas ({min}-{max}): ");
                    var s = Console.ReadLine() ?? string.Empty;
                    var parts = s.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var set = new HashSet<int>();
                    bool ok = true;
                    foreach (var p in parts)
                    {
                        if (!int.TryParse(p.Trim(), out int v) || v < min || v > max) { ok = false; break; }
                        set.Add(v);
                    }
                    if (ok && set.Count > 0) return set;
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                App.Run();
            }
        }
    }
