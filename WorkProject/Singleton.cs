using System;
using System.Collections.Generic;
using System.Text;

namespace WorkProject
{
    //class Singleton
    //{
    //    static void Main(string[] args) {р
    //        Computer comp = new Computer();
    //        comp.Launch("MacOS");
    //        Console.WriteLine(comp.OS.Name);

    //        Computer comp2 = new Computer();
    //        comp2.Launch("Windows 10");                        // объект не создасться!
    //        Console.WriteLine(comp2.OS.Name);
    //    }
    //}

    //class OS {
    //    private static OS instance;

    //    public string Name { get; private set; }

    //    protected OS(string name) {
    //        this.Name = name;
    //    }

    //    public static OS getInstance(string name) {
    //        if (instance == null)                                   // в статическом методе вызывается конструктор для создания объекта 
    //            instance = new OS(name);                           // если конечно объект отсутствует или равен null
    //        return instance;
    //    }
    //}

    //class Computer{

    //    public OS OS { get; set; }
    //    public void Launch (string osNname)
    //    {
    //        OS = OS.getInstance(osNname);
    //    }
    //}
}