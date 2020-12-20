using Microsoft.AspNetCore.Components;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;

namespace AgariTaku.Client.Injector
{
    public class SimpleInjectorComponentActivator : IComponentActivator
    {
        private readonly Container _container;

        public SimpleInjectorComponentActivator(Container container)
        {
            _container = container;
        }

        public IComponent CreateInstance(Type componentType)
        {
            Scope scope = AsyncScopedLifestyle.BeginScope(_container);
            return (IComponent)scope.GetInstance(componentType);
        }
    }
}
