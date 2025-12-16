// See https://aka.ms/new-console-template for more information
using Mediator;

Component1 comp1 = new Component1();
Component2 comp2 = new Component2();
ComponentMediator componentMeditor = new ComponentMediator(comp1,comp2);

comp1.DoA();
comp2.DoD();