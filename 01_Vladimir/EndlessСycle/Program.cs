﻿using System;

namespace EndlessСycle
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            // ініціалізуємо змінну і, якій присвоємо значення 0
            /* За допомогою циклу for можна циклічно виконувати оператор або блок операторів до тих пір,
               поки вказане вираження не буде помилковим. Цей тип циклу корисний для перебору масивів і інших додатків,
               в яких відомо заздалегідь, скільки разів необхідно повторити цикл.*/
            //for (;;)
            /* ініціалізація; умова; ітерація
            (повторювання, повторне застосування математичної операції (із змінними даними) при розв'язанні обчислювальних задач, 
            яке дає можливість поступово наблизитись до правильного результату;
            результат багаторазового повторення якоїсь математичної операції)*/
            //{
            //    i++;
            // інкремент і++ постфіксний інкремент (постінкремент), збільшення змінної і на 1 після виконаного дійства
            // Console.WriteLine("Нескінченний цикл for, i={0}, i");
            //}

            //Оператор while виконує оператор або блок операторів, поки певний вираз не прийме значення false (брехня).
            //while (true)
            //цикл while в умові якого зазначаємо true, ця умова не буде змінюватись й цикл буде виконуватись нескінченно
            //{
            // i++;
            //Console.WriteLine("Нескінченний цикл while, i={0}", i);
            //}

            do
            /*Оператор do повторно виконує оператор або блок операторів, поки певний вираз не прийме значення false.
              Тіло циклу має бути укладено в фігурні дужки {}, якщо воно не складається з однієї інструкції. 
              В цьому випадку фігурні дужки необов'язкові.*/
            {
                i++;
                Console.WriteLine("Нескінченний цикл do-while, i={0}", i);
            } while (true);

        }
    }
}
