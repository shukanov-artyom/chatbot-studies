using System;

namespace HelloBot.Forms
{
    [Serializable]
    public class MedicalQuestionForm
    {
        public MedicalSpecialty Specialty { get; set; }

        public int QuestionsCount { get; set; }

        public bool TurnOnTimeout { get; set; }
    }

    public enum MedicalSpecialty
    {
        Orthopaedics,

        Trauma,

        Sports
    }
}