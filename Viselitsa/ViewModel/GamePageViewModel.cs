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
        public event PropertyChangingEventHandler? PropertyChanged;
        //private List<Word> words = new List<Word>() { new Word() { Word="Овца" }, new Word() { Word="Собака" }, new Word() { Word="Кошка" } };
        private List<String> words = new List<String>() { "Овца", "Собака", "Кошка" };

        private String Word;
        //private String lettersWord { get; set; }
        [ObservableProperty]
        private ObservableCollection<char> _noVisibleWord = new ObservableCollection<char>() { };

        [ObservableProperty]
        private char _letter;
        public GamePageViewModel()
        {
            Random random = new Random();
            int randomInt = random.Next(words.Count);
            Word = words[randomInt];
            //NoVisibleWord = new ObservableCollection<Char>() { };
            
            for (int i = 0; i < Word.Length; i++)
            {
                NoVisibleWord.Add('_');
            }
        }

        [RelayCommand]
        private void GetLetter()
        {
            
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == Letter) {
                    NoVisibleWord.RemoveAt(i);
                    NoVisibleWord.Insert(i, Letter);
                    //NoVisibleWord[i] = Letter;
                } 
            }
            //NoVisibleWord = lettersWord;
        }

        //private void CreateWordElements() 
        //{   
        //    // Почувствовал себя тупым, как же IDE дописывает код, жесть
        //    int randomInt = random.Next(words.Count);
        //    Word = words[randomInt];
        //}

    }
}
