using DesignPatterns.DoFactory.GangOfFour.BehavioralPatterns.ChainOfResponsibility.Structural;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Abstract.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Abstract.Structural;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Builder.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Builder.Structural;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Factory.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Factory.Structural;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Prototype.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Prototype.Structural;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Singleton.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Singleton.Structural;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Adapter.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Adapter.Structural;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Bridge.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Bridge.Structural;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Composite.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Composite.Structural;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Decorator.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Decorator.Structural;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Facade.RealWorld;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Facade.Structural;
using DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAbstractFactory testAbstractFactory = new TestAbstractFactory();
            testAbstractFactory.Test();

            TestContinentFactory testContinentFactory = new TestContinentFactory();
            testContinentFactory.Test();

            BuilderTest builderTest = new BuilderTest();
            builderTest.Test();

            ShopTest shopTest = new ShopTest();
            shopTest.Test();

            FactoryTest factoryTest = new FactoryTest();
            factoryTest.Test();

            PageFactoryTest pageFactoryTest = new PageFactoryTest();
            pageFactoryTest.Test();

            PrototypeTest prototypeTest = new PrototypeTest();
            prototypeTest.Test();

            ColorPrototypeTest colorPrototypeTest = new ColorPrototypeTest();
            colorPrototypeTest.Test();

            SingletonTest singletonTest = new SingletonTest();
            singletonTest.Test();

            LoadBalancerTest loadBalancerTest = new LoadBalancerTest();
            loadBalancerTest.Test();

            AdapterTest adapterTest = new AdapterTest();
            adapterTest.Test();

            CompoundTest compoundTest = new CompoundTest();
            compoundTest.Test();

            BridgeTest bridgeTest = new BridgeTest();
            bridgeTest.Test();

            CustomersTest customersTest = new CustomersTest();
            customersTest.Test();

            ComponentTest componentTest = new ComponentTest();
            componentTest.Test();

            DrawingElementTest drawingElementTest = new DrawingElementTest();
            drawingElementTest.Test();

            AbstractComponentTest abstractComponentTest = new AbstractComponentTest();
            abstractComponentTest.Test();

            LibraryItemTest libraryItemTest = new LibraryItemTest();
            libraryItemTest.Test();

            FacadeTest facadeTest = new FacadeTest();
            facadeTest.Test();

            MortgageTest mortgageTest = new MortgageTest();
            mortgageTest.Test();

            FlyweightFactoryTest flyweightFactoryTest = new FlyweightFactoryTest();
            flyweightFactoryTest.Test();

            HandlerTest handlerTest = new HandlerTest();
            handlerTest.Test();

            Console.ReadKey();
        }
    }
}
