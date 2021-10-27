using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyDemo
{
    abstract class Strategy
    {
        public abstract void Algorithminterface();
    }
    class ConcreateStrategyA : Strategy
    {
        public override void Algorithminterface()
        {
            Console.WriteLine("演算法A的實現");
        }
    }
    class ConcreateStrategyB : Strategy
    {
        public override void Algorithminterface()
        {
            Console.WriteLine("演算法B的實現");
        }
    }
    class ConcreateStrategyC : Strategy
    {
        public override void Algorithminterface()
        {
            Console.WriteLine("演算法C的實現");
        }
    }


    class Context
    {
        private Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterFace()
        {
            this.strategy.Algorithminterface();
        }
    }
}
