using System;
using System.Collections;
using System.Collections.Generic;

class MusicCatalog
{
    private Hashtable catalog = new Hashtable();

    public void AddDisk(string disk) => catalog[disk] = (List<string>)catalog[disk] ?? new List<string>();
    public void RemoveDisk(string disk) => catalog.Remove(disk);
    public void AddSong(string disk, string song) => ((List<string>)catalog[disk])?.Add(song);
    public void RemoveSong(string disk, string song) => ((List<string>)catalog[disk])?.Remove(song);
    public void ViewCatalog() => Console.WriteLine(string.Join("\n",
        new ArrayList(catalog.Keys).ToArray().Select(d =>
            $"Диск: {d}\n  - {string.Join("\n  - ", (List<string>)catalog[d] ?? new List<string>())}")));
}

class Program
{
    static void Main()
    {
        var c = new MusicCatalog();
        c.AddDisk("Rock Classics");
        c.AddSong("Rock Classics", "Bohemian Rhapsody");
        c.AddSong("Rock Classics", "Stairway to Heaven");
        c.ViewCatalog();
    }
}