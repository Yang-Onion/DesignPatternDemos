### 桥模式的组成

 > 桥接模式的结构包括Abstraction、RefinedAbstraction、Implementor、ConcreteImplementorA和ConcreteImplementorB五个部分，其中：

+（1）、抽象化角色(Abstraction)：抽象化给出的定义，并保存一个对实现化对象（Implementor）的引用。

+（2）、修正抽象化角色(Refined Abstraction)：扩展抽象化角色，改变和修正父类对抽象化的定义。

+（3）、实现化角色(Implementor)：这个角色给出实现化角色的接口，但不给出具体的实现。必须指出的是，这个接口不一定和抽象化角色的接口定义相同，实际上，这两个接口可以非常不一样。实现化角色应当只给出底层操作，而抽象化角色应当只给出基于底层操作的更高一层的操作。

+（4）、具体实现化角色(Concrete Implementor)：这个角色给出实现化角色接口的具体实现。

> 在桥接模式中，两个类Abstraction和Implementor分别定义了抽象与行为类型的接口，通过调用两接口的子类实现抽象与行为的动态组合。