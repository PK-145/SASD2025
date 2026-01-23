using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101;

public class LongMethod
{
    // A very long method
    public void PrintReport()
    {
        // Print Header
        // ...........

        // Print Body
        // ...........

        // Print Footer
        // ...........
    }
}

public class ShorterMethod
{
    public void PrintReport()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }
    private void PrintHeader()
    {
        // Print Header
        // ...........
    }
    private void PrintBody()
    {
        // Print Body
        // ...........
    }
    private void PrintFooter()
    {
        // Print Footer
        // ...........
    }
}
