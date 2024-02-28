namespace Adapter.Example1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICommunication
    {
        string Ask(string question);
        string Reply(string answer);
    }
}
