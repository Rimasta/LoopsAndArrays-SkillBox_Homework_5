using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HomeWork : MonoBehaviour
{
    /// <summary>
    /// Метод обработки события OnClick кнопки
    /// "Сумма четных чисел заданного диапазона"
    /// </summary>
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        int got = SumEvenNumbersInRange(min, max);
        int want = Enumerable.Range(min, max - min + 1).Where(val => val % 2 == 0).Sum();
        string message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в диапазоне от {min} до {max} включительно: {got} - {message}");
    }

    
    /// <summary>
    /// Метод вычисляет сумму четных чисел в заданном диапазоне
    /// </summary>
    /// <param name="min">Минимальное значение диапазона</param>
    /// <param name="max">Максимальное значение диапазона</param>
    /// <returns>Сумма чисел четных чисел</returns>
    private int SumEvenNumbersInRange(int min, int max)
    {
        int result = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                result += i;
            }
        }
        return result;
    }
    
 
    /// <summary>
    /// Метод обработки события OnClick кнопки
    /// "Сумма четных чисел в заданном массиве"
    /// </summary>
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = array.Where(val => val % 2 == 0).Sum();
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в заданном массиве: {got} - {message}");
    }
    
    
    /// <summary>
    /// Метод вычисляет сумму четных чисел в массиве
    /// </summary>
    /// <param name="array">Исходный массив чисел</param>
    /// <returns>Сумма чисел четных чисел</returns>
    private int SumEvenNumbersInArray(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result+= array[i];
            }
        }
        return result;
    }

    
    /// <summary>
    /// Метод обработки события OnClick кнопки
    /// "Поиск первого вхождения числа в массив"
    /// </summary>
    public void OnFirstOccurrence()
    {
        // Первый тест, число присутствует в массиве
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = Array.IndexOf(array, value);
        int got = FirstOccurrence(array, value);
        string message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");

        // Второй тест, число не присутствует в массиве
        array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        value = 55;
        want = Array.IndexOf(array, value);
        got = FirstOccurrence(array, value);
        message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");
    }

    
    /// <summary>
    /// Метод производит поиск первого вхождения числа в массив
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <param name="value">Искомое число</param>
    /// <returns>Индекс искомого числа в массиве или -1 если число отсутствует</returns>
    private int FirstOccurrence(int[] array, int value)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                result = i;
                return result;
            }
        }
        return -1;
    }

    
    /// <summary>
    /// Метод обработки события OnClick кнопки
    /// "Сортировка выбором"
    /// </summary>
    public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        string represent = "[" + string.Join(",", originalArray) + "]";
        Debug.Log($"Исходный массив {represent}");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        represent = "[" + string.Join(",", sortedArray) + "]";
        Debug.Log($"Результат {represent}");

        Array.Sort(originalArray);
        Debug.Log(sortedArray.SequenceEqual(originalArray) ? "Результат верный" : "Результат неверный");
    }

    
    /// <summary>
    /// Метод сортирует массив методом выбора
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    private int[] SelectionSort(int[] array)
    {
        int index;
        for (int i = 0; i < array.Length; i++)
        {
            index = i;
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < array[index])
                {
                    index = j;
                }
            }
            if(array[index] == array[i])
                continue;

            int temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
        return array;
    }
}

