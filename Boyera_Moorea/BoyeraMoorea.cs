namespace Algorythims
{
    public class BoyerAndMoore:IAlgorythims
    {
        private string _Text{ get; set; }
        private string _Pattern{ get; set; }

        public BoyerAndMoore()
        {
            UserInput();
            Run();
        }
        public void Run()
        {
            int PatternLastIndex = _Pattern.Length-1;
            int tempTextIndex = PatternLastIndex;
            while(tempTextIndex < _Text.Length)
            {
                if(_Text[tempTextIndex] == _Pattern[PatternLastIndex])
                {
                    int IndexOfFirstChar = tempTextIndex - PatternLastIndex;
                    int IndexOfLastChar = tempTextIndex;
                    if(this.CompareTextWithPattern(IndexOfFirstChar,IndexOfLastChar))
                    {
                        Console.WriteLine($"Znalazłem go na ideksie od {IndexOfFirstChar} do {IndexOfLastChar}");
                        tempTextIndex += _Pattern.Length;
                    }
                }
                else if(this.BelongToPattern(_Text[tempTextIndex],out int index))
                {
                    tempTextIndex += (PatternLastIndex-index);
                }
                else
                {
                    tempTextIndex += _Pattern.Length;
                }
            }
        }

        private bool BelongToPattern(char ch, out int index)
        {
            for(int i = 0; i < _Pattern.Length; i++)
            {
                if(ch == _Pattern[i])
                {
                    index = i;
                    return true;
                }
            }
            index = 0;
            return false;
        }
        private bool CompareTextWithPattern(int FirstCharIndex, int LastCharIndex)
        {
            for(int i = FirstCharIndex; i<=LastCharIndex; i++)
            {
                if(_Text[i] != _Pattern[i-FirstCharIndex])
                {
                    return false;
                }
            }
            return true;
        }
        public void UserInput()
        {
            Console.Write("Type text: ");
            string text = Console.ReadLine();   
            Console.Write("Type Pattern: ");
            string pattern = Console.ReadLine(); 
            if(text != "" && pattern != "")
            {
                _Text = text;
                _Pattern = pattern;
                if(text.Length < pattern.Length)
                {
                   throw new ArgumentException("Incorrect arguments.. Text cannot be longer that pattern");
                }
            }
            else
            {
                throw new ArgumentException("One or more elements are empty");
            }
        }
    }
}