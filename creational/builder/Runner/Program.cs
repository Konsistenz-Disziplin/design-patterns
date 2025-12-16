// See https://aka.ms/new-console-template for more information
using Builder;
ProductBuilder productBuilder = new ProductBuilder();
Director director = new Director(productBuilder);
director.BuildMinimalProduct();
productBuilder.GetProduct().ListParts();
director.BuildFullFeaturedProduct();
productBuilder.GetProduct().ListParts();
