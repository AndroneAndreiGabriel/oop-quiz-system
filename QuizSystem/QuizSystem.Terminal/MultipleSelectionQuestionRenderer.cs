using QuizSystem.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.Terminal
{
    public class MultipleSelectionQuestionRenderer : QuestionRenderer
    {
        public override bool CanRenderQuestion(Question question)
        {
            return question is MultipleSelectionQuestion;
        }

        public override void RenderQuestion(int questionNo, Question question)
        {
            //randeaza single
            if (question is MultipleSelectionQuestion multipleSelectionQuestion)
            {
                //randeaza multiple
                Console.WriteLine($"{ questionNo}) {multipleSelectionQuestion.Text}");
                for (int i = 0; i < multipleSelectionQuestion.Options.Length; i++)
                {
                    Console.WriteLine($"    {i}: {multipleSelectionQuestion.Options[i]}");
                }
                Console.Write("Please choose one or more options indices (comma separated)=");
            }
            else
            {
                throw new NotSupportedException();
            }
        }
    }
}
