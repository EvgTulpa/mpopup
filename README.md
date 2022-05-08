# Example:
![mpSeq](https://user-images.githubusercontent.com/103635242/167291669-0f65c444-5f12-4e1e-a1cc-74d4d5c9fb45.png)<br><br>
Класс TestPopupSpawner вызывает метод в ссылке на объект типа MurkaPopupCreator, но сам этот объект не инстанциирован на сцене, и все манипуляции по добавлению попапа идут через MurkaPopupCreator.<br><br>
MurkaPopupCreator становится промежуточным звеном до PopupCreator, и все обработки попапа скрыты в колекциях процесах MurkaPopupCreator, которые выставлены через интерфейсы.<br><br>
Добавление нового процесса никак не должно менять код MurkaPopupCreator, такая главная задумка<br>
![1](https://user-images.githubusercontent.com/103635242/167291691-589b78f9-f093-49c6-954a-4c1850e45711.png)<br><br>

MurkaPopupCreatorData - есть набор данных, которыми должен обладать наш попап, который добавиться через PopupCreator.<br>
Пока что добавленно два процесса.<br>
1) MurkaIgnorePopupProcessor - он позволяет сделать попап игнорируемым.<br>
2) MurkaOnlyViewPopupProcessor - он позволяет удалить попап из очереди попапов, и дать возможность показаться следующему попапу в очереди, НО текущий попап не удалять визуально сразу, а дать возможность удалить его самому, FeatureOneMurkaOnlyViewPopupProcessor - удаляет его после анимации. 
