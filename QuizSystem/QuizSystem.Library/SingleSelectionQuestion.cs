using System;

namespace QuizSystem.Library
{
    public class SingleSelectionQuestion : Question
    {
        public SingleSelectionQuestion(
            int id,
            string text,
            string[] options,
            int correctOptionIndex)
            : base(id, text)
        {
            Options = options;
            CorrectOptionsIndex = correctOptionIndex;
        }
        public string[] Options { get; }
        public int CorrectOptionsIndex { get; }

        public override decimal GetScoreForAnswer(string answer)
        {
            if (string.IsNullOrWhiteSpace(answer))
            {
                return 0;
            }

            if (!int.TryParse(answer, out int resultIndex))
            {
                return 0;
            }

            return (resultIndex == CorrectOptionsIndex)
                ? 1M
                : 0M;
        }
    }
}
