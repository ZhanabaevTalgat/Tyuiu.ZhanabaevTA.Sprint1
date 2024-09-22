using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            List<string> SymmetricalWords = new List<string>();
            string[] Words = value.Split(" ");
            for (int i = 0; i < Words.Length; i++)
            {
                string word = Words[i].ToLower();
                if (word.Length % 2 == 1 && word.Length != 1)
                { 
                    int Medium = (word.Length - 1) / 2;
                    int k = 1;
                    for (int j = 0, r = word.Length-1; j < Medium; j++, r--)
                    {
                        if (word[j] == word[r])
                            { k += 2; }
                    }
                    if (k == word.Length)
                    {
                        SymmetricalWords.Add(Words[i]);
                    }
                }
            }
            return String.Join(", ", SymmetricalWords);
        }
    }
}
