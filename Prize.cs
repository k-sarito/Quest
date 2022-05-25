using System;


namespace Quest {
        public class Prize {
            private string _text {get; set;}

            public Prize (string text)
            {
                _text = text;
            }

            public void ShowPrize (Adventurer variableName)
            {
                if(variableName.Awesomeness > 0)
                {
                    for (int i = 0; i< variableName.Awesomeness; i++)
                    {
                        Console.WriteLine(_text);
                    }
                    
                }
                else if (variableName.Awesomeness <= 0)
                {
                    Console.WriteLine("Pity");
                }
            }


        }

}
