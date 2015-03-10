using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public interface IDeveloper
    {
        // подписываемся на новый набор
        void ApplyDeveloper(Institute institute);
        // отвечаем на вопрос
        bool AnswerQuestion(string question);
        // подаем заявку на отчисление
        void LeaveDeveloper(Institute institute);
        // текущая оценка
        int DevRating { get; set; }
    }
}
