using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorokina_lab1.Services
{
    public class Service1
    {
    public int a;
    public int b;

    public string titlle = "AccessServiceDirectly";

    public int add;
    public int sub;
    public int mult;
    public int div;

    Random rnd = new Random();

    public void Service()
    {
        a = rnd.Next(0, 10);
        b = rnd.Next(0, 10);

        add = a + b;
        sub = a - b;
        mult = a * b;
        if (b != 0) div = a / b;
        else div = -1;
    }
}
}
