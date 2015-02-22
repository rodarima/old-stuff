

#include "stdafx.h"



#using <mscorlib.dll>
#using <System.dll>
using namespace System;
using namespace System::Text;
using namespace System::Net;
using namespace System::Net::NetworkInformation;
using namespace System::ComponentModel;
using namespace System::Threading;


void PingCompletedCallback (Object* sender, PingCompletedEventArgs* e);
void DisplayReply (PingReply* reply);

int main ()
{
    String* args[] = Environment::GetCommandLineArgs();

    if (args->Length == 1)
        throw new ArgumentException (S"Ping needs a host or IP Address.");

    String* who = args[1];
    AutoResetEvent* waiter = new AutoResetEvent (false);

    Ping* pingSender = new Ping ();

    // When the PingCompleted event is raised,
    // the PingCompletedCallback method is called.
    pingSender->PingCompleted += new PingCompletedEventHandler (PingCompletedCallback);

    // Create a buffer of 32 bytes of data to be transmitted.
    String* data = S"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
    Byte buffer[] = Encoding::ASCII->GetBytes (data);

    // Wait 12 seconds for a reply.
    int timeout = 12000;

    // Set options for transmission:
    // The data can go through 64 gateways or routers
    // before it is destroyed, and the data packet
    // cannot be fragmented.
    PingOptions* options = new PingOptions (64, true);

    Console::WriteLine (S"Time to live: {0}", __box(options->Ttl));
    Console::WriteLine (S"Don't fragment: {0}", __box(options->DontFragment));

    // Send the ping asynchronously.
    // Use the waiter as the user token.
    // When the callback completes, it can wake up this thread.
    pingSender->SendAsync (who, buffer, timeout, options, waiter);

    // Prevent this example application from ending.
    // A real application should do something useful
    // when possible.
    waiter->WaitOne ();
    Console::WriteLine (S"Ping example completed.");
}

void PingCompletedCallback (Object* /*sender*/, PingCompletedEventArgs* e)
{
    // If the operation was canceled, display a message to the user.
    if (e->Cancelled)
    {
        Console::WriteLine (S"Ping canceled.");

        // Let the main thread resume. 
        // UserToken is the AutoResetEvent object that the main thread 
        // is waiting for.
        (dynamic_cast<AutoResetEvent*>(e->UserToken))->Set ();
    }

    // If an error occurred, display the exception to the user.
    if (e->Error != 0)
    {
        Console::WriteLine (S"Ping failed:");
        Console::WriteLine (e->Error->ToString ());

        // Let the main thread resume. 
        (dynamic_cast<AutoResetEvent*>(e->UserToken))->Set ();
    }

    PingReply* reply = e->Reply;

    DisplayReply (reply);

    // Let the main thread resume.
    (dynamic_cast<AutoResetEvent*>(e->UserToken))->Set ();
}

void DisplayReply (PingReply* reply)
{
    if (reply == 0)
        return;

    Console::WriteLine (S"ping status: {0}", __box(reply->Status));
    if (reply->Status == IPStatus::Success)
    {
        Console::WriteLine (S"Address: {0}", reply->Address->ToString ());
        Console::WriteLine (S"RoundTrip time: {0}", __box(reply->RoundTripTime));
        Console::WriteLine (S"Time to live: {0}", __box(reply->Options->Ttl));
        Console::WriteLine (S"Don't fragment: {0}", __box(reply->Options->DontFragment));
        Console::WriteLine (S"Buffer size: {0}", __box(reply->Buffer->Length));
    }
}
