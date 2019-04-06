using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hangman.Hangman;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;

namespace hangman.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IMemoryCache _cache;
        public IndexModel(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void OnGet()
        {
            ViewData["PlayerName"] = "";
        }

        public void OnPostStartGame()
        {

            // Store the player's name in memory
            _cache.Set("PlayerName", Request.Form["PlayerName"]);

            // Create a copy  
            ViewData["PlayerName"] = _cache.Get("PlayerName");

            // Store the max number of Guesses
           _cache.Set<int>("MaxGuesses", int.Parse(Request.Form["MaxGuesses"]));

            // Set the GuessCount to 0 to start
            _cache.Set<int>("GuessCount", 0);

            // At the beginning, the word hasn't been guessed yet. 
            _cache.Set("WordNotGuessedYet", "true");

            // Set guessesRemaining = to the MaxGuesses, because no guesses have been made yet.
            _cache.Set<int>("GuessesRemaining", _cache.Get<int>("MaxGuesses"));
            ViewData["GuessesRemaining"] = _cache.Get<int>("GuessesRemaining");

            // Set UnguessedLetters to all 26 letters
            //_cache.Set<SortedSet<char>>("UnguessedLetters", Hangman.Utilities.AllLetters);

            // Set GuessedLetters to an empty set
            _cache.Set<SortedSet<char>>("GuessedLetters", new SortedSet<char>());

            // Set UnguessedWord to a randomly selected word
            _cache.Set<string>("SecretWord", Hangman.Utilities.GetRandomWord());
            ViewData["SecretWord"] = _cache.Get<string>("SecretWord");
            ViewData["MaskedWord"] = MaskedWord().ToUpper();
            ViewData["Message"] = "Welcome to Hangman, " + _cache.Get("PlayerName");
            ViewData["alertClass"] = "info";
        }

        public void OnPostMakeGuess(char guessedLetter)
        {
            ViewData["PlayerName"] = _cache.Get("PlayerName");
            ViewData["SecretWord"] = _cache.Get("SecretWord");
            ViewData["Message"] = "Welcome to Hangman, " + _cache.Get("PlayerName");
            ViewData["alertClass"] = "info";

            // Add the guessed letter to the guessedletters list 
            var currentGuessedLetters = _cache.Get<SortedSet<char>>("GuessedLetters");
            currentGuessedLetters.Add(guessedLetter);
            _cache.Set<SortedSet<char>>("GuessedLetters", currentGuessedLetters);

            // If the user has guessed all of the letters in the secret word, you're done. 
            if (HasWordBeenGuessed())
            {
                ViewData["Message"] = "You win!";
                ViewData["alertClass"] = "success";
                ViewData["MaskedWord"] = MaskedWord().ToUpper();
                return;
            }
            else
            {
                // Otherwise: 
                // Decrease the number of guesses remaining 
                var guessesRemaining = _cache.Get<int>("GuessesRemaining") - 1;
                _cache.Set<int>("GuessesRemaining", guessesRemaining);
                ViewData["GuessesRemaining"] = _cache.Get<int>("GuessesRemaining");

                ViewData["MaskedWord"] = MaskedWord().ToUpper();
                
                if (_cache.Get<int>("GuessesRemaining") == 0)
                {
                    ViewData["Message"] = "Womp womp. You have no guesses left. The word was '" + _cache.Get("SecretWord") + "'.";
                    ViewData["alertClass"] = "danger";
                    ViewData["MaskedWord"] = MaskedWord().ToUpper();
                    return;
                }
            }
            
        }

        public int GuessCount()
        {
            var _guessedLetters = _cache.Get<SortedSet<char>>("GuessedLetters");
            return _guessedLetters.Count;
        }

        public int IncorrectGuessCount()
        {
            var _guessedLetters = _cache.Get<SortedSet<char>>("GuessedLetters");
            var _word = _cache.Get<string>("SecretWord");
            return _guessedLetters.Except(_word.ToCharArray()).Count();
            
        }

        public int GuessesRemaining()
        {
            return _cache.Get<int>("MaxGuesses") - _cache.Get<int>("IncorrectGuessCount");
        }

        public bool HasLetterBeenGuessed(char letter)
        {
            var _guessedLetters = _cache.Get<SortedSet<char>>("GuessedLetters");
            return _guessedLetters.Contains(Char.ToUpper(letter));
        }

        public bool HasWordBeenGuessed()
        {
            var _word = _cache.Get<string>("SecretWord");
            var lettersInWord = new SortedSet<char>(_word.ToUpper());
            var guessedLetters = _cache.Get<SortedSet<char>>("GuessedLetters");
            return lettersInWord.SetEquals(lettersInWord.Intersect(guessedLetters));
        }

        public IEnumerable<char> UnguessedLetters()
        {
           return Hangman.Utilities.AllLetters.Except(_cache.Get<SortedSet<char>>("GuessedLetters"));
        }

        public IEnumerable<char> GuessedLetters()
        {
            return _cache.Get<SortedSet<char>>("GuessedLetters");
        }

        public string MaskedWord()
        {
           var maskedCharacters = _cache.Get<string>("SecretWord")
                    .ToCharArray()
                    .SelectMany(
                        letter => GetMaskedLetter(letter));

                return new string(maskedCharacters.ToArray()).Trim();
        }

        public IEnumerable<char> GetMaskedLetter(char letter)
        {
            return HasLetterBeenGuessed(letter) ?
                                new char[] { letter, ' ' } :
                                new char[] { '_', ' ' };
        }
    }
}
