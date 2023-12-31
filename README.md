# FinalTask
## Описание задачи
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры верной работы программы:

```“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```

## Критерии выполнения
Для полноценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод).
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах).
***

## Алгоритм решения задачи
1. Объявляем два массива:
- первый массив будет введен пользователем с клавиатуры (arraySourse);
- второй массив будет итоговым и по длине должен равняться первому массиву (arrayFinal).
2. Пишем метод 1 (ArrayFinal): он будет проверять каждый элемент исходного массива на условие (<=3). Если условие проверки "==true", то проверяемый элемент заноситься в переменную "item".
3. Далее из переменной "item" проверяемые элементы будут передаваться в итоговый массив.
4. Пишем метод 2(PrintArrayFinal): данный метод будет выводить итоговый массив в консоль.