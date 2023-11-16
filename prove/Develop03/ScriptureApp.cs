using System;
using System.Collections.Generic;

namespace ScriptureApp
{
    class Reference
    {
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }

        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
        }

        public override string ToString()
        {
            return $"{Book} {Chapter}:{Verse}";
        }
    }

    class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Word> words;
        private Random random = new Random();

        public Scripture(string book, int chapter, int verse, string text)
        {
            Reference = new Reference(book, chapter, verse);
            words = new List<Word>();
            foreach (var wordText in text.Split(' '))
            {
                words.Add(new Word(wordText));
            }
        }

        public void HideRandomWord()
        {
            if (words.Count == 0) return;

            int index = random.Next(words.Count);
            words[index].Hide();
        }

        public bool IsFullyHidden()
        {
            foreach (var word in words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string result = $"{Reference}: ";
            foreach (var word in words)
            {
                result += word.GetRenderedText() + " ";
            }
            return result;
        }
    }

    class Word
    {
        public string Text { get; private set; }
        private bool hidden;

        public Word(string text)
        {
            Text = text;
            hidden = false;
        }

        public void Hide()
        {
            hidden = true;
        }

        public bool IsHidden()
        {
            return hidden;
        }

        public string GetRenderedText()
        {
            return hidden ? "___" : Text;
        }
    }
}