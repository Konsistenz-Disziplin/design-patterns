// See https://aka.ms/new-console-template for more information
using Composite;

var client = new Client();
var leaf = new Leaf();
client.DoTree(leaf);

var tree = new CompositeConcrete();
var branch1 = new CompositeConcrete();
var branch2 = new CompositeConcrete();
branch1.Add(new Leaf());
branch1.Add(new Leaf());
branch2.Add(new Leaf());
tree.Add(branch1);
tree.Add(branch2);
client.DoTree(tree);
client.Do2Composite(tree, leaf);

