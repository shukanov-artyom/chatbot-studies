using System;
using Microsoft.Bot.Builder.FormFlow;

namespace HelloBot.Forms
{
    public class MedicalQuestionFormBuilder
    {
        public IForm<MedicalQuestionForm> BuildForm()
        {
            return new FormBuilder<MedicalQuestionForm>()
                .Message("Welcome. Please answer a couple of questions to pass a test.")
                .Build();
        }
    }
}