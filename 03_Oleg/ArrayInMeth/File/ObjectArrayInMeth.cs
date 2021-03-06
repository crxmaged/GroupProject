﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayInMeth.File
{
    class ObjectArrayInMeth
    {
        /* Метод возращает массив array, содержащий множитель аргумента num.
         * При возврате из метода параметр numfactors типа out будет содержать 
         * количество обнаруженных множителей. */

        /* Может появится вопрос а зачем нам переменная common? 
         * Очень хороший вопрос, мы задаем длину массива числом number, но мы еще не знаем 
         * сколько элементов массива будут множителями числа, а для вывода всех множителей мы 
         * используем цикл в методе Main, и количество итераций будет зависить от количества множителей */
        public int [] ReturnArray (int number, out int common)
        {
            int[] ClassArray = new int[number];         // размер массива будет равен чмслу что введено 
            int i, j;                                   // переменная i содержит значения элементов массива
                                                        // перменная j содержит порядковый номер элемента массива 
                                                        // все множители будут записаны как элементы массива ClassArray
            for (i = 2, j = 0; i < number/2 + 1; i++)   // цикл для инициализации массива типа int 
            {                                           // массив будет заполнятся элементами которые будут удовлетворять все - 
                if( (number%i) == 0)                    // - условия (цикла и ветвления)
                {                                       // все элементы буду записаны как элементы массива
                    ClassArray[j] = i;                  // душа просит расписать как это работает!
                    j++;                                // конечно можно просто F11 нажимать. Но мы ж ленивые)))
                }                                       // И так с метода Main мы получили значение аргумента 1000 -
            }                                           // - данный аргумент мы используем как значения для проверки на условие 500 + 1
            common = j;                                 // данное значение используем в цикле как условие в методе Main   
            return ClassArray;       
        }
    }
}
