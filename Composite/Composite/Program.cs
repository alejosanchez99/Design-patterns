using Composite.Example1;

AppFile appFile1 = new AppFile("File1");
AppFile appFile2 = new AppFile("File2");
AppFile appFile3 = new AppFile("File3");

Folder folder1 = new Folder("Folder 1");
folder1.AddItem(appFile1);

Folder folder2 = new Folder("Folder 2");
folder2.AddItem(appFile2);
folder2.AddItem(appFile3);

Folder root = new Folder("root");
root.AddItem(folder1);
root.AddItem(folder2);
root.Display();