Factory Method
==============
Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

Structure
---------
<img src="image.png" />

Applicability
-------------
Use the Factory Method pattern when
* a class can’t anticipate the class of objects it must create;
* a class wants its subclasses to specify the objects it creates;
* classes delegate responsibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate.


Фабричный метод
===============
Определяет интерфейс объекта, но оставляет подклассам решение о том, какой класс инстанцировать. Фабричный метод позволяет классу делегировать инстанцирование подклассам.

Структура
---------
<img src="image.png" />

Применимость
------------
Используйте паттерн фабричный метод, когда:
* классе заранее неизвестно, объекты каких классов ему нужно создавать;
* класс спроектирован так, чтобы объекты, которые он создает, специфицировались подклассами;
* класс делегирует свои обязанности одному из нескольких вспомогательных подклассов, и вы планируете локализовать знание о том, какой класс принимает эти обязанности на себя.