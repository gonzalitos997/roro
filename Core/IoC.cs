using System;
using System.Collections.Generic;

namespace BatchProcess3.Core;

/// <summary>
/// Simple IoC (Inversion of Control) container for dependency injection
/// </summary>
public class IoC
{
    private static readonly Dictionary<Type, object> _services = new();

    /// <summary>
    /// Registers a service instance
    /// </summary>
    /// <typeparam name="T">Service type</typeparam>
    /// <param name="implementation">Implementation instance</param>
    public static void Register<T>(T implementation) where T : class
    {
        _services[typeof(T)] = implementation;
    }

    /// <summary>
    /// Resolves a service instance
    /// </summary>
    /// <typeparam name="T">Service type</typeparam>
    /// <returns>Service instance</returns>
    public static T Resolve<T>() where T : class
    {
        if (_services.TryGetValue(typeof(T), out var service))
        {
            return (T)service;
        }

        throw new InvalidOperationException($"Service of type {typeof(T).Name} not registered");
    }

    /// <summary>
    /// Tries to resolve a service instance
    /// </summary>
    /// <typeparam name="T">Service type</typeparam>
    /// <param name="service">Resolved service or null</param>
    /// <returns>True if service was resolved, false otherwise</returns>
    public static bool TryResolve<T>(out T? service) where T : class
    {
        if (_services.TryGetValue(typeof(T), out var obj))
        {
            service = (T)obj;
            return true;
        }

        service = null;
        return false;
    }

    /// <summary>
    /// Clears all registered services
    /// </summary>
    public static void Clear()
    {
        _services.Clear();
    }
}
