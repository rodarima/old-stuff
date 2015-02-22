using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

namespace Fecha_y_Hora
{
    class Program
    {
        static void Main(string[] args)
        {

    string msgShortDate = "(d) Short date: . . . . . . . ";
    string msgLongDate  = "(D) Long date:. . . . . . . . ";
    string msgShortTime = "(t) Short time: . . . . . . . ";
    string msgLongTime  = "(T) Long time:. . . . . . . . ";
    string msgFullDateShortTime = 
                          "(f) Full date/short time: . . ";
    string msgFullDateLongTime =
                          "(F) Full date/long time:. . . ";
    string msgGeneralDateShortTime = 
                          "(g) General date/short time:. ";
    string msgGeneralDateLongTime = 
                          "(G) General date/long time (default):\n" +
                          "    . . . . . . . . . . . . . ";
    string msgMonth   =   "(M) Month:. . . . . . . . . . ";
    string msgRFC1123 =   "(R) RFC1123:. . . . . . . . . ";
    string msgSortable =  "(s) Sortable: . . . . . . . . ";
    string msgUniSortInvariant = 
                          "(u) Universal sortable (invariant):\n" + 
                          "    . . . . . . . . . . . . . ";
    string msgUniSort =   "(U) Universal sortable: . . . ";
    string msgYear =      "(Y) Year: . . . . . . . . . . ";
    string msgRoundtripLocal        = "(o) Roundtrip (local):. . . . ";
    string msgRoundtripUTC          = "(o) Roundtrip (UTC):. . . . . ";
    string msgRoundtripUnspecified  = "(o) Roundtrip (Unspecified):. ";


    string msg1 = "Use ToString(String) and the current thread culture.\n";
    string msg2 = "Use ToString(String, IFormatProvider) and a specified culture.\n";
    string msgCulture  = "Culture:";
    string msgThisDate = "This date and time: {0}\n";

    DateTime thisDate  = DateTime.Now;
    DateTime  utcDate  = thisDate.ToUniversalTime();
    DateTime unspecifiedDate = new DateTime(2000, 3, 20, 13, 2, 3, 0, DateTimeKind.Unspecified);
    CultureInfo ci;

// Format the current date and time in various ways.
    Console.Clear();
    Console.WriteLine("Standard DateTime Format Specifiers:\n");
    Console.WriteLine(msgThisDate, thisDate);
    Console.WriteLine(msg1);

// Display the thread current culture, which is used to format the values.
    ci = Thread.CurrentThread.CurrentCulture;
    Console.WriteLine("{0,-30}{1}\n", msgCulture, ci.DisplayName);

    Console.WriteLine(msgShortDate            +         thisDate.ToString("d"));
    Console.WriteLine(msgLongDate             +         thisDate.ToString("D"));
    Console.WriteLine(msgShortTime            +         thisDate.ToString("t"));
    Console.WriteLine(msgLongTime             +         thisDate.ToString("T"));
    Console.WriteLine(msgFullDateShortTime    +         thisDate.ToString("f"));
    Console.WriteLine(msgFullDateLongTime     +         thisDate.ToString("F"));
    Console.WriteLine(msgGeneralDateShortTime +         thisDate.ToString("g"));
    Console.WriteLine(msgGeneralDateLongTime  +         thisDate.ToString("G"));
    Console.WriteLine(msgMonth                +         thisDate.ToString("M"));
    Console.WriteLine(msgRFC1123              +          utcDate.ToString("R"));
    Console.WriteLine(msgSortable             +         thisDate.ToString("s"));
    Console.WriteLine(msgUniSortInvariant     +          utcDate.ToString("u"));
    Console.WriteLine(msgUniSort              +         thisDate.ToString("U"));
    Console.WriteLine(msgYear                 +         thisDate.ToString("Y"));
    Console.WriteLine(msgRoundtripLocal       +         thisDate.ToString("o"));
    Console.WriteLine(msgRoundtripUTC         +          utcDate.ToString("o"));
    Console.WriteLine(msgRoundtripUnspecified +  unspecifiedDate.ToString("o"));

    Console.WriteLine();

// Display the same values using a CultureInfo object. The CultureInfo class 
// implements IFormatProvider.
    Console.WriteLine(msg2);

// Display the culture used to format the values. 
    ci = new CultureInfo("de-DE");
    Console.WriteLine("{0,-30}{1}\n", msgCulture, ci.DisplayName);

    Console.WriteLine(msgShortDate            +         thisDate.ToString("d", ci));
    Console.WriteLine(msgLongDate             +         thisDate.ToString("D", ci));
    Console.WriteLine(msgShortTime            +         thisDate.ToString("t", ci));
    Console.WriteLine(msgLongTime             +         thisDate.ToString("T", ci));
    Console.WriteLine(msgFullDateShortTime    +         thisDate.ToString("f", ci));
    Console.WriteLine(msgFullDateLongTime     +         thisDate.ToString("F", ci));
    Console.WriteLine(msgGeneralDateShortTime +         thisDate.ToString("g", ci));
    Console.WriteLine(msgGeneralDateLongTime  +         thisDate.ToString("G", ci));
    Console.WriteLine(msgMonth                +         thisDate.ToString("M", ci));
    Console.WriteLine(msgRFC1123              +         utcDate.ToString("R", ci));
    Console.WriteLine(msgSortable             +         thisDate.ToString("s", ci));
    Console.WriteLine(msgUniSortInvariant     +         utcDate.ToString("u", ci));
    Console.WriteLine(msgUniSort              +         thisDate.ToString("U", ci));
    Console.WriteLine(msgYear                 +         thisDate.ToString("Y", ci));
    Console.WriteLine(msgRoundtripLocal       +         thisDate.ToString("o", ci));
    Console.WriteLine(msgRoundtripUTC         +          utcDate.ToString("o", ci));
    Console.WriteLine(msgRoundtripUnspecified +  unspecifiedDate.ToString("o", ci));

    Console.WriteLine();
    Console.ReadLine();
    }
}
/*
This code example produces the following results:

Standard DateTime Format Specifiers:

This date and time: 4/17/2006 2:22:48 PM

Use ToString(String) and the current thread culture.

Culture:                      English (United States)

(d) Short date: . . . . . . . 4/17/2006
(D) Long date:. . . . . . . . Monday, April 17, 2006
(t) Short time: . . . . . . . 2:22 PM
(T) Long time:. . . . . . . . 2:22:48 PM
(f) Full date/short time: . . Monday, April 17, 2006 2:22 PM
(F) Full date/long time:. . . Monday, April 17, 2006 2:22:48 PM
(g) General date/short time:. 4/17/2006 2:22 PM
(G) General date/long time (default):
    . . . . . . . . . . . . . 4/17/2006 2:22:48 PM
(M) Month:. . . . . . . . . . April 17
(R) RFC1123:. . . . . . . . . Mon, 17 Apr 2006 21:22:48 GMT
(s) Sortable: . . . . . . . . 2006-04-17T14:22:48
(u) Universal sortable (invariant):
    . . . . . . . . . . . . . 2006-04-17 21:22:48Z
(U) Universal sortable: . . . Monday, April 17, 2006 9:22:48 PM
(Y) Year: . . . . . . . . . . April, 2006
(o) Roundtrip (local):. . . . 2006-04-17T14:22:48.2698750-07:00
(o) Roundtrip (UTC):. . . . . 2006-04-17T21:22:48.2698750Z
(o) Roundtrip (Unspecified):. 2000-03-20T13:02:03.0000000

Use ToString(String, IFormatProvider) and a specified culture.

Culture:                      German (Germany)

(d) Short date: . . . . . . . 17.04.2006
(D) Long date:. . . . . . . . Montag, 17. April 2006
(t) Short time: . . . . . . . 14:22
(T) Long time:. . . . . . . . 14:22:48
(f) Full date/short time: . . Montag, 17. April 2006 14:22
(F) Full date/long time:. . . Montag, 17. April 2006 14:22:48
(g) General date/short time:. 17.04.2006 14:22
(G) General date/long time (default):
    . . . . . . . . . . . . . 17.04.2006 14:22:48
(M) Month:. . . . . . . . . . 17 April
(R) RFC1123:. . . . . . . . . Mon, 17 Apr 2006 21:22:48 GMT
(s) Sortable: . . . . . . . . 2006-04-17T14:22:48
(u) Universal sortable (invariant):
    . . . . . . . . . . . . . 2006-04-17 21:22:48Z
(U) Universal sortable: . . . Montag, 17. April 2006 21:22:48
(Y) Year: . . . . . . . . . . April 2006
(o) Roundtrip (local):. . . . 2006-04-17T14:22:48.2698750-07:00
(o) Roundtrip (UTC):. . . . . 2006-04-17T21:22:48.2698750Z
(o) Roundtrip (Unspecified):. 2000-03-20T13:02:03.0000000

*/
    }

