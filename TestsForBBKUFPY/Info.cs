using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsForBBKUFPY
{
    static class Info
    {
        public static List<String> __questions = new List<string>(); //Список вопросов
        public static List<String> __answers = new List<string>(); //Список вопросов
        public static int __time; //время таймера
        public static int success; //верные ответы

        public static void Clear() //Очистка списков
        {
            __questions.Clear();
            __answers.Clear();
        }
    }
}
