// See https://aka.ms/new-console-template for more information
using Command;
Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("invoker start"));
Receiver receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand("Send Email","Do Report",receiver));
invoker.Do();