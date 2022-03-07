using QuizSystem.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.Terminal
{
    public class SingleSelectionQuestionRenderer : QuestionRenderer
    {
        public override bool CanRenderQuestion(Question question)
        {
            return question is SingleSelectionQuestion;
        }

        public override void RenderQuestion(int questionNo, Question question)
        {
            //randeaza single
            if (question is SingleSelectionQuestion singleSelectionQuestion)
            {
                Console.WriteLine($"{ questionNo}) {singleSelectionQuestion.Text}");

                for (int i = 0; i < singleSelectionQuestion.Options.Length; i++)
                {
                    Console.WriteLine($"    {i}: {singleSelectionQuestion.Options[i]}");
                }
                Console.Write("Please choose a single option index=");
            }
            else
            {
                throw new NotSupportedException();
            }
        }
    }
}
