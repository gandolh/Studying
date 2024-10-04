
#region factory pattern
//using DesignPatterns.Factory;

//// factory pattern - creates object of some kind having an context.
//// os type should be got by configuration / system environment
//FactoryMain factoryMain = new FactoryMain(OsType.Windows);
//factoryMain.main();

// abstract factory
#endregion

#region abstract factory pattern
//using DesignPatterns.AbstractFactory;
//// the abstract factory is the gui factory.
//// it is a factory but it is abstract. Other factories inherits this.
//AbstractFactoryMain abstractFactoryMain = new AbstractFactoryMain(OsType.Mac);
//abstractFactoryMain.Main();
#endregion

#region builder pattern
//using DesignPatterns.Builder;
//// builder pattern use methods to build the object.
//BuilderMain builderMain = new BuilderMain();
//builderMain.Main();

#endregion

#region Prototype pattern

//using DesignPatterns.Prototype;
//// There exists an interface (prototype) that has method: Clone.
//// The clone method uses a copy constructor (or clone in clone method) and creates
//// a new object that is copy of current object
//PrototypeMain prototypeMain = new PrototypeMain();
//prototypeMain.Main();

#endregion

#region Singleton pattern
//using DesignPatterns.Singleton;
//SingletonMain singletonMain = new SingletonMain();
//singletonMain.Main();
#endregion

#region Adapter pattern
//using DesignPatterns.Adapter;

//AdapterMain adapterMain = new AdapterMain();
//adapterMain.Main();

#endregion
#region Bridge pattern
//using DesignPatterns.Bridge;

//BridgeMain bridgeMain = new BridgeMain();
//bridgeMain.Main();
#endregion
#region Composite pattern
//using DesignPatterns.Composite;

//CompositeMain compositeMain = new CompositeMain();
//compositeMain.Main();

#endregion
#region Decorator pattern
//using DesignPatterns.Decorator;

//DecoratorMain decoratorMain = new DecoratorMain();
//decoratorMain.Main();
#endregion
#region Facade Pattern
//using DesignPatterns.Facade;

//FacadeMain main = new FacadeMain();
//main.Main();
#endregion

#region Flyweight pattern
//using DesignPatterns.Flyweight;

//FlyweightMain flyweightMain = new FlyweightMain();
//flyweightMain.Main();
#endregion
#region Proxy pattern
//using DesignPatterns.Proxy;

//ProxyMain proxyMain = new ProxyMain();
//proxyMain.Main();

#endregion

#region Chain of responsability
//using DesignPatterns.ChainOfResponsability;

//CorMain corMain = new CorMain();
//corMain.Main();
#endregion

#region Command Pattern
//using DesignPatterns.CommandPattern;

//CommandMain commandMain = new CommandMain();
//commandMain.Main();

#endregion
#region Iterator pattern
//using DesignPatterns.IteratorPattern;

//IteratorMain iteratorMain = new IteratorMain();
//iteratorMain.Main();
#endregion

#region Mediator pattern
//using DesignPatterns.Mediator;

//MediatorMain mediatorMain = new MediatorMain();
//mediatorMain.Main();
#endregion

#region Memento pattern
//using DesignPatterns.Memento;

//MementoMain mementoMain = new MementoMain();
//mementoMain.Main();

#endregion

#region Observer pattern
//using DesignPatterns.Observer;

//ObserverMain observerMain = new ObserverMain();
//observerMain.Main();

#endregion

#region State pattern
//using DesignPatterns.State;

//StateMain stateMain = new StateMain();
//stateMain.Main();
#endregion

#region Strategy pattern
//using DesignPatterns.Strategy;

//StrategyMain strategyMain = new StrategyMain();
//strategyMain.Main();
#endregion
#region Template pattern
//using DesignPatterns.Template;

//TemplateMain templateMain = new TemplateMain();
//templateMain.Main();
#endregion

#region Visitor pattern

using DesignPatterns.Visitor;

VisitorMain visitorMain = new VisitorMain();
visitorMain.Main();

#endregion
