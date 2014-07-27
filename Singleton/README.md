Singleton
========
Ensure a class only has one instance, and provide a global point of access to it. His implementation ensures a unique instance.
Applicability
--------------
Use the singleton pattern when:
* there must be exactly one instance of a class, and it must be accessible to clients from a well-known access point.
* when the sole instance should be extensible by subclassing, and clients should be able to use an extended instance without modifying their code.

Versions
-----------
1. **Not thread-safe**. Two different threads could both have evaluated the test if (instance==null) and found it to be true, then both create instances, which violates the singleton pattern. Note that in fact the instance may already have been created before the expression is evaluated, but the memory model doesn't guarantee that the new value of instance will be seen by other threads unless suitable memory barriers have been passed.
2. **Simple thread-safety**. This implementation is thread-safe. The thread takes out a lock on a shared object, and then checks whether or not the instance has been created before creating the instance. This takes care of the memory barrier issue (as locking makes sure that all reads occur logically after the lock acquire, and unlocking makes sure that all writes occur logically before the lock release) and ensures that only one thread will create an instance (as only one thread can be in that part of the code at a time - by the time the second thread enters it, the first thread will have created the instance, so the expression will evaluate to false). Unfortunately, performance suffers as a lock is acquired every time the instance is requested.
3. **Attempted thread-safety using double-check locking**. This implementation attempts to be thread-safe without the necessity of taking out a lock every time. Unfortunately, there are four downsides to the pattern:
  * It doesn't work in Java. This may seem an odd thing to comment on, but it's worth knowing if you ever need the singleton pattern in Java, and C# programmers may well also be Java programmers. The Java memory model doesn't ensure that the constructor completes before the reference to the new object is assigned to instance. The Java memory model underwent a reworking for version 1.5, but double-check locking is still broken after this without a volatile variable (as in C#).
  * Without any memory barriers, it's broken in the ECMA CLI specification too. It's possible that under the .NET 2.0 memory model (which is stronger than the ECMA spec) it's safe, but I'd rather not rely on those stronger semantics, especially if there's any doubt as to the safety. Making the instance variable volatile can make it work, as would explicit memory barrier calls, although in the latter case even experts can't agree exactly which barriers are required. I tend to try to avoid situations where experts don't agree what's right and what's wrong!
  * It's easy to get wrong. The pattern needs to be pretty much exactly as above - any significant changes are likely to impact either performance or correctness.
  * It still doesn't perform as well as the later implementations.
4. **Not quite as lazy, but thread-safe without using locks**. Static constructors in C# are specified to execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain. Given that this check for the type being newly constructed needs to be executed whatever else happens, it will be faster than adding extra checking as in the previous examples. There are a couple of wrinkles, however:
  * It's not as lazy as the other implementations. In particular, if you have static members other than Instance, the first reference to those members will involve creating the instance. This is corrected in the next implementation.
  * There are complications if one static constructor invokes another which invokes the first again. Look in the .NET specifications (currently section 9.5.3 of partition II) for more details about the exact nature of type initializers - they're unlikely to bite you, but it's worth being aware of the consequences of static constructors which refer to each other in a cycle.
  * The laziness of type initializers is only guaranteed by .NET when the type isn't marked with a special flag called beforefieldinit. Unfortunately, the C# compiler (as provided in the .NET 1.1 runtime, at least) marks all types which don't have a static constructor (i.e. a block which looks like a constructor but is marked static) as beforefieldinit. I now have an article with more details about this issue. Also note that it affects performance, as discussed near the bottom of the page.
5. **Fully lazy instantiation**. Instantiation is triggered by the first reference to the static member of the nested class, which only occurs in Instance. This means the implementation is fully lazy, but has all the performance benefits of the previous ones. Note that although nested classes have access to the enclosing class's private members, the reverse is not true, hence the need for instance to be internal here. That doesn't raise any other problems, though, as the class itself is private. The code is a bit more complicated in order to make the instantiation lazy, however.\
6. **Using .NET 4's Lazy<T> type**. If you're using .NET 4 (or higher), you can use the System.Lazy<T> type to make the laziness really simple. All you need to do is pass a delegate to the constructor which calls the Singleton constructor - which is done most easily with a lambda expression.  It's simple and performs well. It also allows you to check whether or not the instance has been created yet with the IsValueCreated property, if you need that.


Одиночка
========
Гарантирует, что класс имеет только один экземпляр и предоставляет глобальную точку доступа к нему. Иными словами, при использовании паттерна одиночка гарантируется единственность экземпляра класса.

Применение
----------------
Используется тогда, когда:
* должен быть ровно один экземпляр некоторого класса, легко доступный всем клиентам;
* единственный экземпляр должен расширяться путем порождения подклассов, и клиентам нужно иметь возможность работать с расширенным экземпляром без модификации своего кода.

Разные версии реализации шаблона
-------------------------------------------------
1. **Не потоко-безопасная**. Наиболее простоя реализация паттерна, неустойчивая к наличию 2 и более одновременно работающих потоков. При такой ситуации, если два потока одновременно проверят сущность на нулевое значение, тогда будет создано два экземпляра класса, что полностью противоречит замыслу.
2. **Простая потоко-безопасная**. Данная версия работает всегда, но имеет существенные недостатки производительности: только один поток может получить значение в один момент времени, это гарантируется структурой lock.
3. **Потоко-безопасная с двойной блокировкой**. Имеет несколько серьёзных недостатков: подобный код не работает на Java (их модель данных не гарантирует, что конструктор завершит свою работу до того, как ссылка на новый объект будет назначена), без использования барьеров памяти, подобная конструкция не будет соответствовать спецификации ECMA CLI, также данная версия не такая производительная как последующие.
4. **Не достаточно ленивая, зато потоко-безопасая версия без двойной блокировки**. Очень простая реализация, но не полностью ленивая: если у класса есть другие статические члены, то при обращении к ним будет выполняться код создания экземпляра синглтона, также необходим пустой (или нет) статический конструктор, для того чтобы компилятор не обозначал класс атрибутом beforinitialize.
5. **Полностью ленивый, потоко-безопасный**. Один из самых лучших вариантов реализации, содержит в себе все преимущества предыдущего способа, но с полной "ленивостью". Недостаток: большой, громоздкий код, в котором легко запутаться.
6. **Используя встроенный класс Lazy<T> в .NET 4.0+**. Самый лучший способ реализации, устроенный приблизительно так же, как и предыдущий, включает в себе несколько полезный методов, таких как IsValueCreated().
