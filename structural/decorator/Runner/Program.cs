// See https://aka.ms/new-console-template for more information
using Decorator;
var compressed = new CompressionDecorator(new FileDataSource());
var encryption = new EncryptionDecorator(compressed);
encryption.WriteData("Sandra");
