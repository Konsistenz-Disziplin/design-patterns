// See https://aka.ms/new-console-template for more information
using Memento;
 Editor editor = new Editor("Start Editor");

 Caretaker caretaker = new Caretaker(editor);

 caretaker.Backup();

 editor.AddRand();

  caretaker.Backup();

 editor.AddRand();

 caretaker.Undo();
 caretaker.Undo();
editor.AddRand();
caretaker.Backup();
 caretaker.Undo();


