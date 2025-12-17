// See https://aka.ms/new-console-template for more information
using Proxy;
Client.Do(new RealSubject());
Client.Do(new ProxyConcrete(new RealSubject()));
