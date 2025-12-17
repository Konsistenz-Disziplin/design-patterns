// See https://aka.ms/new-console-template for more information
using FlyWeight;

 var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );

factory.ListFlyweights();
AddOwnerToTheCar(factory, new Car {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            });
AddOwnerToTheCar(factory, new Car {
Number = "CL234IR",
Owner = "James Doe",
Company = "BMW",
Model = "X1",
Color = "red"
});           
factory.ListFlyweights();
void AddOwnerToTheCar(FlyweightFactory factory , Car car)
{   
    var flyweight = factory.GetFlyWeight(new Car
    {
        Color = car.Color,
        Model = car.Model,
        Company = car.Company
    });
    flyweight.Operation(car);
    

}