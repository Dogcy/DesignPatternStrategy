using System;

namespace strategyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new ConcreateStrategyA());
            context.ContextInterFace();

            context = new Context(new ConcreateStrategyB());
            context.ContextInterFace();

            context = new Context(new ConcreateStrategyC());
            context.ContextInterFace();
        }
    }
}
