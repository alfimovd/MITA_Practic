using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public interface IDeveloper
    {
        // Начать обучение?
        bool IsWantEnterDeveloper();
        // Продолжить обучение?
        bool IsWantLeaveDeveloper();
        // текущая оценка
        int DevRating { get; set; }
    }
}
