using System;
using System.Collections.Generic;

namespace ScriptureApp
{
    class Reference
    {
        public string book;
        public int chapter;
        public int verse;
    }

    class Scripture
    {
        public Reference reference;
        public string text;
        public List<Word> words;

        public void HideWords()
        {
            foreach (Word word in words)
            {
                word.Hide();
            }
        }

        public string GetRenderedText()
        {
            string result = "";
            foreach (Word word in words)
            {
                if (!word.IsHidden())
                {
                    result += word.text + " ";
                }
            }
            return result;
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Word
    {
        public string text;
        public bool hidden;

        public void Hide()
        {
            hidden = true;
        }

        public void Show()
        {
            hidden = false;
        }

        public bool IsHidden()
        {
            return hidden;
        }

        public string GetRenderedText()
        {
            if (!hidden)
            {
                return text;
            }
            return "";
        }
    }
}
