var path = @"D:\Faculdade_Uninove\Git & GitHub\Meus Projetos\project-files-streams\directory-directoryinfo\globo";
using var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine($"Monitorando eventos na pasta {path}");
Console.WriteLine("Pressione [enter] para finalizar....");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi excluído o arquivo {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
}