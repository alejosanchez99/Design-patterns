using Memento.Example2;

Repository repository = new Repository();
Git git = new Git();

repository.Code = "Initial code";
git.Commit(repository);

Console.WriteLine(repository.Code);

repository.Code = "Code after first change";
git.Commit(repository);

Console.WriteLine(repository.Code);

repository.Code = "Code after second change";
git.Commit(repository);

Console.WriteLine(repository.Code);

git.Revert(repository);
Console.WriteLine(repository.Code);

