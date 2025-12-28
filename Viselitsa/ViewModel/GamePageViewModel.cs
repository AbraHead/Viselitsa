using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Viselitsa.View.Pages;
//using Viselitsa.Model;

namespace Viselitsa.ViewModel
{
    internal partial class GamePageViewModel: ObservableObject
    {
        //private List<Word> words = new List<Word>() { new Word() { Word="Овца" }, new Word() { Word="Собака" }, new Word() { Word="Кошка" } };
        private List<string> words = new List<string>() { "Овца", "Собака", "Кошка" };
        private String Word;
        private int life = 5;
        private int lettertry = 0;

        [ObservableProperty]
        private string _visilitsaImage = "viselitsa_1.png";

        [ObservableProperty]
        private string _noVisibleWord;

        [ObservableProperty]
        private char _letter;
        public GamePageViewModel()
        {
            Random random = new Random();
            int randomInt = random.Next(words.Count);
            Word = words[randomInt];
            
            for (int i = 0; i < Word.Length; i++)
            {
                NoVisibleWord += "_";
            }
        }

        [RelayCommand]
        private void GetLetter()
        {
            lettertry += 1;
            bool wordletter = false;
            string newWord = "";
            for (int i = 0; i < Word.Length; i++)
            {
                // Читаемости кода ради можно использовать слова в ловеркейс
                if (Word[i].ToString().Equals(Letter.ToString(), StringComparison.CurrentCultureIgnoreCase)) {
                    newWord += Word[i];
                    wordletter = true;
                } else if (NoVisibleWord[i] != '_')
                {
                    newWord += NoVisibleWord[i];
                } else
                {
                    newWord += "_";
                }
            }

            if (!newWord.Contains('_'))
            {
                Shell.Current.GoToAsync(nameof(GameWin));
                return;
            }

            if (!wordletter) {
                life-=1;
                switch (life)
                {
                    case 5:
                        VisilitsaImage = "viselitsa_1.png";
                        break;
                    case 4:
                        VisilitsaImage = "viselitsa_1.png";
                        break;
                    case 3:
                        VisilitsaImage = "viselitsa_1.png";
                        break;
                    case 2:
                        VisilitsaImage = "viselitsa_1.png";
                        break;
                    case 1:
                        VisilitsaImage = "viselitsa_1.png";
                        break;
                    case 0:
                        Shell.Current.GoToAsync(nameof(GameOver));
                        break;
                }
            }
            
            NoVisibleWord = newWord;
        }

        //private void CreateWordElements() 
        //{   
        //    // Почувствовал себя тупым, как же IDE дописывает код, жесть
        //    int randomInt = random.Next(words.Count);
        //    Word = words[randomInt];
        //}

    }
}
