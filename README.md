# Задание

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение

1. Пробегаем по начальному массиву и проверяем числа на чётность
2. Чётные складываем в начале этого же массива и считаем их количество (count)
3. Дальше вижу два варианта:
    1. создать новый массив и сложить в него числа из начального массива (от 0 до count)
    2. обрезать начальный массив командой Array.Resize до длины count

Не могу определиться какой вариант лучше.
**Второй** будет короче и **читабельнее**, а **первый** (как мне кажется) займёт **меньше ресурсов**.
В Program.cs я приведу оба варианта, один будет закомментирован.
